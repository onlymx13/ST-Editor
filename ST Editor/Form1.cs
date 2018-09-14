using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
//using System.IO.Compression.FileSystem;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ICSharpCode.SharpZipLib.Core;
//using ICSharpCode.SharpZipLib.Zip;
//using ZLibNet;


namespace WindowsFormsApp1
{
    public partial class MainSheet : Form
    {
        int capsByte;
        bool LifeCountTextChangedFires = true;
        public string UpOneLevel(string inputPath) {
            return Path.GetFullPath(Path.Combine(inputPath, @"../"));
        }
        public MainSheet() { InitializeComponent(); }
        string path;
        /*  public void ExtractZipFile(string archiveFilenameIn, string password, string outFolder)
          {
              ZipFile zf = null;
              try
              {
                  FileStream fs = File.OpenRead(archiveFilenameIn);
                  zf = new ZipFile(fs);
                  if (!String.IsNullOrEmpty(password))
                  {
                      zf.Password = password;     // AES encrypted entries are handled automatically
                  }
                  foreach (ZipEntry zipEntry in zf)
                  {
                      if (!zipEntry.IsFile)
                      {
                          continue;           // Ignore directories
                      }
                      String entryFileName = zipEntry.Name;
                      // to remove the folder from the entry:- entryFileName = Path.GetFileName(entryFileName);
                      // Optionally match entrynames against a selection list here to skip as desired.
                      // The unpacked length is available in the zipEntry.Size property.

                      byte[] buffer = new byte[4096];     // 4K is optimum
                      Stream zipStream = zf.GetInputStream(zipEntry);

                      // Manipulate the output filename here as desired.
                      String fullZipToPath = Path.Combine(outFolder, entryFileName);
                      string directoryName = Path.GetDirectoryName(fullZipToPath);
                      if (directoryName.Length > 0)
                          Directory.CreateDirectory(directoryName);

                      // Unzip file in buffered chunks. This is just as fast as unpacking to a buffer the full size
                      // of the file, but does not waste memory.
                      // The "using" will close the stream even if an exception occurs.
                      using (FileStream streamWriter = File.Create(fullZipToPath))
                      {
                          StreamUtils.Copy(zipStream, streamWriter, buffer);
                      }
                  }
              }
              finally
              {
                  if (zf != null)
                  {
                      zf.IsStreamOwner = true; // Makes close also shut the underlying stream
                      zf.Close(); // Ensure we release resources
                  }
              }
          }*/
        public static byte[] Compress(byte[] raw)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory,
                    CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return memory.ToArray();
            }
        }
        static byte[] Decompress(byte[] gzip)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip),
                CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }
        private void OpenFile_Click(object sender, EventArgs e) {
            path = null;

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog()) {
                openFileDialog1.InitialDirectory = @"c:\\";
                openFileDialog1.Filter = "Mupen64 Savestate (*.st)|*.st|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    path = openFileDialog1.FileName;
                    FileNameLabel.Text = "File: " + path;
                }
            }
            if (path != null)
            {
                File.Move(path, Path.ChangeExtension(path, ".gz"));
                path = Path.ChangeExtension(path, ".gz");
                Console.WriteLine(UpOneLevel(path));
                byte[] file = File.ReadAllBytes(path);
                byte[] decompressed = Decompress(file);
                Console.WriteLine(file.Length);
                Console.WriteLine(decompressed.Length);
                File.WriteAllBytes(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", decompressed);

                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    stream.Position = 2128056; //-1 for 0-index ordering, -1 for endianness of byte
                    capsByte = stream.ReadByte();
                    stream.Position = 3388366;
                    LifeCountTextChangedFires = false;
                    LifeCount.Text = ((sbyte)stream.ReadByte()).ToString();
                    LifeCountTextChangedFires = true;
                }
                WingCapCheck.Checked = (capsByte & 2) != 0;
                MetalCapCheck.Checked = (capsByte & 4) != 0;
                VanishCapCheck.Checked = (capsByte & 8) != 0;
            }
        }

        private void AllCaps_Click(object sender, EventArgs e) {
            if (path != null) {
                if (File.Exists(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt")) {
                    using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                    {
                        stream.Position = 2128056; //-1 for 0-index ordering, -1 for endianness of byte
                        capsByte = stream.ReadByte();
                        stream.Position--;
                        capsByte |= 14;//0000 1110. 0x2 is WC, 0x4 is MC, 0x8 is VC
                        stream.WriteByte((byte) capsByte);
                    }
                    WingCapCheck.Checked = (capsByte & 2) != 0;
                    MetalCapCheck.Checked = (capsByte & 4) != 0;
                    VanishCapCheck.Checked = (capsByte & 8) != 0;
                }
            }
        }

        private void SaveFile_Click(object sender, EventArgs e) {
            if (path != null) { 
            if (File.Exists(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt"))
            {
                byte[] file = File.ReadAllBytes(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt");
                byte[] compress = Compress(file);
                File.WriteAllBytes(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".gz", compress);
                File.Move(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".gz", Path.ChangeExtension(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".gz", ".st"));
                File.Delete(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt");
                FileNameLabel.Text = "NO SAVED DATA EXISTS";
            }
        }
            }
        private void NoCaps_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                if (File.Exists(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt"))
                {
                    using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                    {
                        stream.Position = 2128056; //-1 for 0-index ordering, -1 for endianness of byte
                        capsByte = stream.ReadByte();
                        stream.Position--;
                        capsByte = capsByte & ~14;//0000 1110. 0x2 is WC, 0x4 is MC, 0x8 is VC
                        stream.WriteByte((byte) capsByte);
                    }
                    WingCapCheck.Checked = (capsByte & 2) != 0;
                    MetalCapCheck.Checked = (capsByte & 4) != 0;
                    VanishCapCheck.Checked = (capsByte & 8) != 0;
                }
            }
        }

        private void WingCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
            {
                stream.Position = 2128056; //-1 for 0-index ordering, -1 for endianness of byte
                capsByte = stream.ReadByte();
                stream.Position--;
                if (WingCapCheck.Checked)
                {
                    capsByte = capsByte | 2;//0000 0010. 0x2 is WC, 0x4 is MC, 0x8 is VC
                }
                else
                {
                    capsByte = capsByte & ~2;//0000 0010. 0x2 is WC, 0x4 is MC, 0x8 is VC
                }
                stream.WriteByte((byte)capsByte);
            }
        }
        private void MetalCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
            {
                stream.Position = 2128056; //-1 for 0-index ordering, -1 for endianness of byte
                capsByte = stream.ReadByte();
                stream.Position--;
                if (MetalCapCheck.Checked)
                {
                    capsByte = capsByte | 4;//0000 0100. 0x2 is WC, 0x4 is MC, 0x8 is VC
                }
                else
                {
                    capsByte = capsByte & ~4;//0000 0100. 0x2 is WC, 0x4 is MC, 0x8 is VC
                }
                stream.WriteByte((byte)capsByte);
            }
        }

        private void VanishCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
            {
                stream.Position = 2128056; //-1 for 0-index ordering, -1 for endianness of byte
                capsByte = stream.ReadByte();
                stream.Position--;
                if (VanishCapCheck.Checked)
                {
                    capsByte = capsByte | 8;//0000 1000. 0x2 is WC, 0x4 is MC, 0x8 is VC
                }
                else
                {
                    capsByte = capsByte & ~8;//0000 1000. 0x2 is WC, 0x4 is MC, 0x8 is VC
                }
                stream.WriteByte((byte)capsByte);
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LifeCount_TextChanged(object sender, EventArgs e)
        {
            if (LifeCountTextChangedFires)
            {
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    stream.Position = 3388366;
                    int.TryParse(LifeCount.Text, out int lifeCount);
                    stream.WriteByte((byte) lifeCount);
                }
            }
        }
    }
}

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

namespace WindowsFormsApp1
{
    public partial class MainSheet : Form
    {
        int capsByte;
        bool TextChangedFires = true;
        public string UpOneLevel(string inputPath) {
            return Path.GetFullPath(Path.Combine(inputPath, @"../"));
        }
        public MainSheet() { InitializeComponent(); }
        string path;
        public static uint AddressToPointer (uint address)
        {
            address += 0x1B0;
            Console.WriteLine(3 + address - 2 * (address % 4));
            return 3 + address - 2 * (address % 4);
        }
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
               // Console.WriteLine(file.Length);
               // Console.WriteLine(decompressed.Length);
                File.WriteAllBytes(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", decompressed);
                TextChangedFires = false;
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    stream.Position = AddressToPointer(0x0020770B);
                    capsByte = stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B21D);
                    LifeCount.Text = ((sbyte)stream.ReadByte()).ToString();
                    byte[] HOLPx;
                    HOLPx = new byte[4];
                    stream.Position = AddressToPointer(0x0033B3C8);
                    HOLPx[3] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3C9);
                    HOLPx[2] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3CA);
                    HOLPx[1] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3CB);
                    HOLPx[0] = (byte)stream.ReadByte();
                    HOLPXTextBox.Text = System.BitConverter.ToSingle(HOLPx,0).ToString();
                    byte[] HOLPy;
                    HOLPy = new byte[4];
                    stream.Position = AddressToPointer(0x0033B3CC);
                    HOLPy[3] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3CD);
                    HOLPy[2] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3CE);
                    HOLPy[1] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3CF);
                    HOLPy[0] = (byte)stream.ReadByte();
                    HOLPYTextBox.Text = System.BitConverter.ToSingle(HOLPy, 0).ToString();
                    byte[] HOLPz;
                    HOLPz = new byte[4];
                    stream.Position = AddressToPointer(0x0033B3D0);
                    HOLPz[3] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3D1);
                    HOLPz[2] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3D2);
                    HOLPz[1] = (byte)stream.ReadByte();
                    stream.Position = AddressToPointer(0x0033B3D3);
                    HOLPz[0] = (byte)stream.ReadByte();
                    HOLPZTextBox.Text = System.BitConverter.ToSingle(HOLPz, 0).ToString();
                }
                WingCapCheck.Checked = (capsByte & 2) != 0;
                MetalCapCheck.Checked = (capsByte & 4) != 0;
                VanishCapCheck.Checked = (capsByte & 8) != 0;
                TextChangedFires = true;
            }
        }

        private void AllCaps_Click(object sender, EventArgs e) {
            if (path != null) {
                if (File.Exists(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt")) {
                    using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                    {
                        stream.Position = AddressToPointer(0x0020770B);
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
                        stream.Position = AddressToPointer(0x0020770B);
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
            if (path != null)
            {
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    stream.Position = AddressToPointer(0x0020770B);
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
        }
        private void MetalCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (path != null)
            {
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    stream.Position = AddressToPointer(0x0020770B);
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
        }

        private void VanishCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (path != null)
            {
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    stream.Position = AddressToPointer(0x0020770B);
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
        }

        private void LifeCount_TextChanged(object sender, EventArgs e)
        {
            if (path != null && TextChangedFires) {
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    stream.Position = AddressToPointer(0x0033B21D);
                    int.TryParse(LifeCount.Text, out int lifeCount);
                    stream.WriteByte((byte)lifeCount);
                }
            }
        }

        private void HOLPXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (path != null && TextChangedFires)
            {
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    float.TryParse(HOLPXTextBox.Text, out float HOLPX);
                    byte[] HOLPx = System.BitConverter.GetBytes(HOLPX);
                    stream.Position = AddressToPointer(0x0033B3C8);
                    stream.WriteByte(HOLPx[3]); //backwards for endianness
                    stream.Position = AddressToPointer(0x0033B3C9);
                    stream.WriteByte(HOLPx[2]);
                    stream.Position = AddressToPointer(0x0033B3CA);
                    stream.WriteByte(HOLPx[1]);
                    stream.Position = AddressToPointer(0x0033B3CB);
                    stream.WriteByte(HOLPx[0]);
                }
            }
        }

        private void HOLPYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (path != null && TextChangedFires)
            {
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    float.TryParse(HOLPYTextBox.Text, out float HOLPY);
                    byte[] HOLPy = System.BitConverter.GetBytes(HOLPY);
                    stream.Position = AddressToPointer(0x0033B3CC);
                    stream.WriteByte(HOLPy[3]); //backwards for endianness
                    stream.Position = AddressToPointer(0x0033B3CD);
                    stream.WriteByte(HOLPy[2]);
                    stream.Position = AddressToPointer(0x0033B3CE);
                    stream.WriteByte(HOLPy[1]);
                    stream.Position = AddressToPointer(0x0033B3CF);
                    stream.WriteByte(HOLPy[0]);
                }
            }
        }

        private void HOLPZTextBox_TextChanged(object sender, EventArgs e)
        {
            if (path != null && TextChangedFires)
            {
                using (var stream = new FileStream(UpOneLevel(path) + Path.GetFileNameWithoutExtension(path) + ".txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    float.TryParse(HOLPZTextBox.Text, out float HOLPZ);
                    byte[] HOLPz = System.BitConverter.GetBytes(HOLPZ);
                    stream.Position = AddressToPointer(0x0033B3D0);
                    stream.WriteByte(HOLPz[3]); //backwards for endianness
                    stream.Position = AddressToPointer(0x0033B3D1);
                    stream.WriteByte(HOLPz[2]);
                    stream.Position = AddressToPointer(0x0033B3D2);
                    stream.WriteByte(HOLPz[1]);
                    stream.Position = AddressToPointer(0x0033B3D3);
                    stream.WriteByte(HOLPz[0]);
                }
            }
        }
    }
}

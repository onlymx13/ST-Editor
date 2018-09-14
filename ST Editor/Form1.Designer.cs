namespace WindowsFormsApp1
{
    partial class MainSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.AllCaps = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.NoCaps = new System.Windows.Forms.Button();
            this.Watermark = new System.Windows.Forms.Label();
            this.WingCapCheck = new System.Windows.Forms.CheckBox();
            this.MetalCapCheck = new System.Windows.Forms.CheckBox();
            this.VanishCapCheck = new System.Windows.Forms.CheckBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.LifeCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(305, 91);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 50F);
            this.Title.Location = new System.Drawing.Point(223, -17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(351, 95);
            this.Title.TabIndex = 1;
            this.Title.Text = "ST Editor";
            // 
            // AllCaps
            // 
            this.AllCaps.Location = new System.Drawing.Point(305, 120);
            this.AllCaps.Name = "AllCaps";
            this.AllCaps.Size = new System.Drawing.Size(75, 23);
            this.AllCaps.TabIndex = 2;
            this.AllCaps.Text = "All Caps";
            this.AllCaps.UseVisualStyleBackColor = true;
            this.AllCaps.Click += new System.EventHandler(this.AllCaps_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(386, 91);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(75, 23);
            this.SaveFile.TabIndex = 3;
            this.SaveFile.Text = "Save/Close";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(317, 65);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(135, 13);
            this.FileNameLabel.TabIndex = 5;
            this.FileNameLabel.Text = "NO SAVED DATA EXISTS";
            // 
            // NoCaps
            // 
            this.NoCaps.Location = new System.Drawing.Point(386, 120);
            this.NoCaps.Name = "NoCaps";
            this.NoCaps.Size = new System.Drawing.Size(75, 23);
            this.NoCaps.TabIndex = 6;
            this.NoCaps.Text = "No Caps";
            this.NoCaps.UseVisualStyleBackColor = true;
            this.NoCaps.Click += new System.EventHandler(this.NoCaps_Click);
            // 
            // Watermark
            // 
            this.Watermark.AutoSize = true;
            this.Watermark.Location = new System.Drawing.Point(-1, 433);
            this.Watermark.Name = "Watermark";
            this.Watermark.Size = new System.Drawing.Size(276, 13);
            this.Watermark.TabIndex = 7;
            this.Watermark.Text = "This resource brought to you by MMMMMMMMMMMMM";
            // 
            // WingCapCheck
            // 
            this.WingCapCheck.AutoSize = true;
            this.WingCapCheck.Location = new System.Drawing.Point(342, 150);
            this.WingCapCheck.Name = "WingCapCheck";
            this.WingCapCheck.Size = new System.Drawing.Size(79, 17);
            this.WingCapCheck.TabIndex = 8;
            this.WingCapCheck.Text = "Wing Cap?";
            this.WingCapCheck.UseVisualStyleBackColor = true;
            this.WingCapCheck.CheckedChanged += new System.EventHandler(this.WingCapCheck_CheckedChanged);
            // 
            // MetalCapCheck
            // 
            this.MetalCapCheck.AutoSize = true;
            this.MetalCapCheck.Location = new System.Drawing.Point(342, 173);
            this.MetalCapCheck.Name = "MetalCapCheck";
            this.MetalCapCheck.Size = new System.Drawing.Size(80, 17);
            this.MetalCapCheck.TabIndex = 9;
            this.MetalCapCheck.Text = "Metal Cap?";
            this.MetalCapCheck.UseVisualStyleBackColor = true;
            this.MetalCapCheck.CheckedChanged += new System.EventHandler(this.MetalCapCheck_CheckedChanged);
            // 
            // VanishCapCheck
            // 
            this.VanishCapCheck.AutoSize = true;
            this.VanishCapCheck.Location = new System.Drawing.Point(342, 196);
            this.VanishCapCheck.Name = "VanishCapCheck";
            this.VanishCapCheck.Size = new System.Drawing.Size(86, 17);
            this.VanishCapCheck.TabIndex = 10;
            this.VanishCapCheck.Text = "Vanish Cap?";
            this.VanishCapCheck.UseVisualStyleBackColor = true;
            this.VanishCapCheck.CheckedChanged += new System.EventHandler(this.VanishCapCheck_CheckedChanged);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // LifeCount
            // 
            this.LifeCount.Location = new System.Drawing.Point(386, 223);
            this.LifeCount.Name = "LifeCount";
            this.LifeCount.Size = new System.Drawing.Size(100, 20);
            this.LifeCount.TabIndex = 12;
            this.LifeCount.TextChanged += new System.EventHandler(this.LifeCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Life Count/Display";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LifeCount);
            this.Controls.Add(this.VanishCapCheck);
            this.Controls.Add(this.MetalCapCheck);
            this.Controls.Add(this.WingCapCheck);
            this.Controls.Add(this.Watermark);
            this.Controls.Add(this.NoCaps);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.AllCaps);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.OpenFile);
            this.Name = "MainSheet";
            this.Text = "ST Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button AllCaps;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button NoCaps;
        private System.Windows.Forms.Label Watermark;
        private System.Windows.Forms.CheckBox WingCapCheck;
        private System.Windows.Forms.CheckBox MetalCapCheck;
        private System.Windows.Forms.CheckBox VanishCapCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox LifeCount;
        private System.Windows.Forms.Label label1;
    }
}


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
            this.AllCaps = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.NoCaps = new System.Windows.Forms.Button();
            this.Watermark = new System.Windows.Forms.Label();
            this.WingCapCheck = new System.Windows.Forms.CheckBox();
            this.MetalCapCheck = new System.Windows.Forms.CheckBox();
            this.VanishCapCheck = new System.Windows.Forms.CheckBox();
            this.LifeCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HOLPXLabel = new System.Windows.Forms.Label();
            this.HOLPXTextBox = new System.Windows.Forms.TextBox();
            this.HOLPYLabel = new System.Windows.Forms.Label();
            this.HOLPYTextBox = new System.Windows.Forms.TextBox();
            this.HOLPZLabel = new System.Windows.Forms.Label();
            this.HOLPZTextBox = new System.Windows.Forms.TextBox();
            this.gpboxCaps = new System.Windows.Forms.GroupBox();
            this.gpHOLP = new System.Windows.Forms.GroupBox();
            this.gpHUD = new System.Windows.Forms.GroupBox();
            this.killMario = new System.Windows.Forms.Button();
            this.fullHpMario = new System.Windows.Forms.Button();
            this.starDispl = new System.Windows.Forms.TextBox();
            this.starCountl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpboxCaps.SuspendLayout();
            this.gpHOLP.SuspendLayout();
            this.gpHUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(358, 9);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(94, 38);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // AllCaps
            // 
            this.AllCaps.Location = new System.Drawing.Point(6, 113);
            this.AllCaps.Name = "AllCaps";
            this.AllCaps.Size = new System.Drawing.Size(57, 23);
            this.AllCaps.TabIndex = 2;
            this.AllCaps.Text = "All Caps";
            this.AllCaps.UseVisualStyleBackColor = true;
            this.AllCaps.Click += new System.EventHandler(this.AllCaps_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(458, 9);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(94, 38);
            this.SaveFile.TabIndex = 3;
            this.SaveFile.Text = "Save/Close";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(135, 13);
            this.FileNameLabel.TabIndex = 5;
            this.FileNameLabel.Text = "NO SAVED DATA EXISTS";
            // 
            // NoCaps
            // 
            this.NoCaps.Location = new System.Drawing.Point(69, 113);
            this.NoCaps.Name = "NoCaps";
            this.NoCaps.Size = new System.Drawing.Size(77, 23);
            this.NoCaps.TabIndex = 6;
            this.NoCaps.Text = "No Caps";
            this.NoCaps.UseVisualStyleBackColor = true;
            this.NoCaps.Click += new System.EventHandler(this.NoCaps_Click);
            // 
            // Watermark
            // 
            this.Watermark.AutoSize = true;
            this.Watermark.Location = new System.Drawing.Point(9, 457);
            this.Watermark.Name = "Watermark";
            this.Watermark.Size = new System.Drawing.Size(276, 13);
            this.Watermark.TabIndex = 7;
            this.Watermark.Text = "This resource brought to you by MMMMMMMMMMMMM";
            // 
            // WingCapCheck
            // 
            this.WingCapCheck.AutoSize = true;
            this.WingCapCheck.Location = new System.Drawing.Point(6, 21);
            this.WingCapCheck.Name = "WingCapCheck";
            this.WingCapCheck.Size = new System.Drawing.Size(73, 17);
            this.WingCapCheck.TabIndex = 8;
            this.WingCapCheck.Text = "Wing Cap";
            this.WingCapCheck.UseVisualStyleBackColor = true;
            this.WingCapCheck.CheckedChanged += new System.EventHandler(this.WingCapCheck_CheckedChanged);
            // 
            // MetalCapCheck
            // 
            this.MetalCapCheck.AutoSize = true;
            this.MetalCapCheck.Location = new System.Drawing.Point(6, 44);
            this.MetalCapCheck.Name = "MetalCapCheck";
            this.MetalCapCheck.Size = new System.Drawing.Size(74, 17);
            this.MetalCapCheck.TabIndex = 9;
            this.MetalCapCheck.Text = "Metal Cap";
            this.MetalCapCheck.UseVisualStyleBackColor = true;
            this.MetalCapCheck.CheckedChanged += new System.EventHandler(this.MetalCapCheck_CheckedChanged);
            // 
            // VanishCapCheck
            // 
            this.VanishCapCheck.AutoSize = true;
            this.VanishCapCheck.Location = new System.Drawing.Point(6, 67);
            this.VanishCapCheck.Name = "VanishCapCheck";
            this.VanishCapCheck.Size = new System.Drawing.Size(80, 17);
            this.VanishCapCheck.TabIndex = 10;
            this.VanishCapCheck.Text = "Vanish Cap";
            this.VanishCapCheck.UseVisualStyleBackColor = true;
            this.VanishCapCheck.CheckedChanged += new System.EventHandler(this.VanishCapCheck_CheckedChanged);
            // 
            // LifeCount
            // 
            this.LifeCount.Location = new System.Drawing.Point(121, 25);
            this.LifeCount.Name = "LifeCount";
            this.LifeCount.Size = new System.Drawing.Size(81, 20);
            this.LifeCount.TabIndex = 12;
            this.LifeCount.TextChanged += new System.EventHandler(this.LifeCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Life Count/Display";
            // 
            // HOLPXLabel
            // 
            this.HOLPXLabel.AutoSize = true;
            this.HOLPXLabel.Location = new System.Drawing.Point(6, 35);
            this.HOLPXLabel.Name = "HOLPXLabel";
            this.HOLPXLabel.Size = new System.Drawing.Size(46, 13);
            this.HOLPXLabel.TabIndex = 14;
            this.HOLPXLabel.Text = "HOLP X";
            // 
            // HOLPXTextBox
            // 
            this.HOLPXTextBox.Location = new System.Drawing.Point(55, 32);
            this.HOLPXTextBox.Name = "HOLPXTextBox";
            this.HOLPXTextBox.Size = new System.Drawing.Size(75, 20);
            this.HOLPXTextBox.TabIndex = 15;
            this.HOLPXTextBox.TextChanged += new System.EventHandler(this.HOLPXTextBox_TextChanged);
            // 
            // HOLPYLabel
            // 
            this.HOLPYLabel.AutoSize = true;
            this.HOLPYLabel.Location = new System.Drawing.Point(6, 63);
            this.HOLPYLabel.Name = "HOLPYLabel";
            this.HOLPYLabel.Size = new System.Drawing.Size(46, 13);
            this.HOLPYLabel.TabIndex = 14;
            this.HOLPYLabel.Text = "HOLP Y";
            // 
            // HOLPYTextBox
            // 
            this.HOLPYTextBox.Location = new System.Drawing.Point(55, 60);
            this.HOLPYTextBox.Name = "HOLPYTextBox";
            this.HOLPYTextBox.Size = new System.Drawing.Size(75, 20);
            this.HOLPYTextBox.TabIndex = 15;
            this.HOLPYTextBox.TextChanged += new System.EventHandler(this.HOLPYTextBox_TextChanged);
            // 
            // HOLPZLabel
            // 
            this.HOLPZLabel.AutoSize = true;
            this.HOLPZLabel.Location = new System.Drawing.Point(6, 91);
            this.HOLPZLabel.Name = "HOLPZLabel";
            this.HOLPZLabel.Size = new System.Drawing.Size(46, 13);
            this.HOLPZLabel.TabIndex = 14;
            this.HOLPZLabel.Text = "HOLP Z";
            // 
            // HOLPZTextBox
            // 
            this.HOLPZTextBox.Location = new System.Drawing.Point(55, 88);
            this.HOLPZTextBox.Name = "HOLPZTextBox";
            this.HOLPZTextBox.Size = new System.Drawing.Size(75, 20);
            this.HOLPZTextBox.TabIndex = 15;
            this.HOLPZTextBox.TextChanged += new System.EventHandler(this.HOLPZTextBox_TextChanged);
            // 
            // gpboxCaps
            // 
            this.gpboxCaps.Controls.Add(this.AllCaps);
            this.gpboxCaps.Controls.Add(this.NoCaps);
            this.gpboxCaps.Controls.Add(this.WingCapCheck);
            this.gpboxCaps.Controls.Add(this.MetalCapCheck);
            this.gpboxCaps.Controls.Add(this.VanishCapCheck);
            this.gpboxCaps.Location = new System.Drawing.Point(12, 42);
            this.gpboxCaps.Name = "gpboxCaps";
            this.gpboxCaps.Size = new System.Drawing.Size(152, 142);
            this.gpboxCaps.TabIndex = 16;
            this.gpboxCaps.TabStop = false;
            this.gpboxCaps.Text = "Caps";
            // 
            // gpHOLP
            // 
            this.gpHOLP.Controls.Add(this.HOLPXLabel);
            this.gpHOLP.Controls.Add(this.HOLPXTextBox);
            this.gpHOLP.Controls.Add(this.HOLPZTextBox);
            this.gpHOLP.Controls.Add(this.HOLPYLabel);
            this.gpHOLP.Controls.Add(this.HOLPYTextBox);
            this.gpHOLP.Controls.Add(this.HOLPZLabel);
            this.gpHOLP.Location = new System.Drawing.Point(182, 42);
            this.gpHOLP.Name = "gpHOLP";
            this.gpHOLP.Size = new System.Drawing.Size(158, 142);
            this.gpHOLP.TabIndex = 17;
            this.gpHOLP.TabStop = false;
            this.gpHOLP.Text = "HOLP";
            // 
            // gpHUD
            // 
            this.gpHUD.Controls.Add(this.killMario);
            this.gpHUD.Controls.Add(this.fullHpMario);
            this.gpHUD.Controls.Add(this.starDispl);
            this.gpHUD.Controls.Add(this.starCountl);
            this.gpHUD.Controls.Add(this.label2);
            this.gpHUD.Controls.Add(this.label1);
            this.gpHUD.Controls.Add(this.LifeCount);
            this.gpHUD.Location = new System.Drawing.Point(18, 190);
            this.gpHUD.Name = "gpHUD";
            this.gpHUD.Size = new System.Drawing.Size(322, 112);
            this.gpHUD.TabIndex = 18;
            this.gpHUD.TabStop = false;
            this.gpHUD.Text = "HUD";
            // 
            // killMario
            // 
            this.killMario.Location = new System.Drawing.Point(63, 83);
            this.killMario.Name = "killMario";
            this.killMario.Size = new System.Drawing.Size(52, 23);
            this.killMario.TabIndex = 17;
            this.killMario.Text = "Kill";
            this.killMario.UseVisualStyleBackColor = true;
            this.killMario.Click += new System.EventHandler(this.killMario_Click);
            // 
            // fullHpMario
            // 
            this.fullHpMario.Location = new System.Drawing.Point(6, 83);
            this.fullHpMario.Name = "fullHpMario";
            this.fullHpMario.Size = new System.Drawing.Size(51, 23);
            this.fullHpMario.TabIndex = 17;
            this.fullHpMario.Text = "Heal";
            this.fullHpMario.UseVisualStyleBackColor = true;
            this.fullHpMario.Click += new System.EventHandler(this.fullHpMario_Click);
            // 
            // starDispl
            // 
            this.starDispl.Location = new System.Drawing.Point(164, 52);
            this.starDispl.Name = "starDispl";
            this.starDispl.Size = new System.Drawing.Size(38, 20);
            this.starDispl.TabIndex = 16;
            this.starDispl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // starCountl
            // 
            this.starCountl.Location = new System.Drawing.Point(121, 52);
            this.starCountl.Name = "starCountl";
            this.starCountl.Size = new System.Drawing.Size(38, 20);
            this.starCountl.TabIndex = 15;
            this.starCountl.TextChanged += new System.EventHandler(this.starCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Star Count/Display";
            // 
            // MainSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 324);
            this.Controls.Add(this.gpHUD);
            this.Controls.Add(this.gpHOLP);
            this.Controls.Add(this.gpboxCaps);
            this.Controls.Add(this.Watermark);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainSheet";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ST Editor";
            this.Load += new System.EventHandler(this.MainSheet_Load);
            this.gpboxCaps.ResumeLayout(false);
            this.gpboxCaps.PerformLayout();
            this.gpHOLP.ResumeLayout(false);
            this.gpHOLP.PerformLayout();
            this.gpHUD.ResumeLayout(false);
            this.gpHUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button AllCaps;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button NoCaps;
        private System.Windows.Forms.Label Watermark;
        private System.Windows.Forms.CheckBox WingCapCheck;
        private System.Windows.Forms.CheckBox MetalCapCheck;
        private System.Windows.Forms.CheckBox VanishCapCheck;
        private System.Windows.Forms.TextBox LifeCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HOLPXLabel;
        private System.Windows.Forms.TextBox HOLPXTextBox;
        private System.Windows.Forms.Label HOLPYLabel;
        private System.Windows.Forms.TextBox HOLPYTextBox;
        private System.Windows.Forms.Label HOLPZLabel;
        private System.Windows.Forms.TextBox HOLPZTextBox;
        private System.Windows.Forms.GroupBox gpboxCaps;
        private System.Windows.Forms.GroupBox gpHOLP;
        private System.Windows.Forms.GroupBox gpHUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox starCountl;
        private System.Windows.Forms.TextBox starDispl;
        private System.Windows.Forms.Button fullHpMario;
        private System.Windows.Forms.Button killMario;
    }
}


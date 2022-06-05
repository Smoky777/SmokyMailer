namespace SmokyMailerPro
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabMail = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.LblFile = new System.Windows.Forms.Label();
            this.LstMail = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CheckEncode = new System.Windows.Forms.CheckBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnCenter = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.CheckHtml = new System.Windows.Forms.CheckBox();
            this.BtnClf = new System.Windows.Forms.Button();
            this.BtnClr = new System.Windows.Forms.Button();
            this.TxtFile = new System.Windows.Forms.TextBox();
            this.BtnAttach = new System.Windows.Forms.Button();
            this.BtnUnder = new System.Windows.Forms.Button();
            this.BtnItalic = new System.Windows.Forms.Button();
            this.BtnStrike = new System.Windows.Forms.Button();
            this.BtnBold = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbSize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSbj = new System.Windows.Forms.TextBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnSmtp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CheckSsl = new System.Windows.Forms.CheckBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.TabMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.TabMail);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // TabMail
            // 
            this.TabMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabMail.Controls.Add(this.label13);
            this.TabMail.Controls.Add(this.TxtTo);
            this.TabMail.Controls.Add(this.label1);
            this.TabMail.Controls.Add(this.BtnReset);
            this.TabMail.Controls.Add(this.LblCount);
            this.TabMail.Controls.Add(this.label2);
            this.TabMail.Controls.Add(this.pictureBox1);
            this.TabMail.Controls.Add(this.BtnClear);
            this.TabMail.Controls.Add(this.BtnStop);
            this.TabMail.Controls.Add(this.BtnSend);
            this.TabMail.Controls.Add(this.BtnFile);
            this.TabMail.Controls.Add(this.LblFile);
            this.TabMail.Controls.Add(this.LstMail);
            this.TabMail.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabMail.Location = new System.Drawing.Point(4, 25);
            this.TabMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabMail.Name = "TabMail";
            this.TabMail.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabMail.Size = new System.Drawing.Size(770, 458);
            this.TabMail.TabIndex = 0;
            this.TabMail.Text = "MAIL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(318, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(402, 31);
            this.label13.TabIndex = 12;
            this.label13.Text = "The Best Tools for eMarketer!";
            // 
            // TxtTo
            // 
            this.TxtTo.Location = new System.Drawing.Point(225, 7);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(277, 25);
            this.TxtTo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mail To";
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(667, 427);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(96, 26);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset Send";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(405, 433);
            this.LblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(19, 20);
            this.LblCount.TabIndex = 8;
            this.LblCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Send :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::SmokyMailerPro.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(409, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(640, 7);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(59, 23);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(578, 7);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(54, 23);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "STOP";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(509, 7);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(61, 23);
            this.BtnSend.TabIndex = 3;
            this.BtnSend.Text = "SEND";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnFile
            // 
            this.BtnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFile.Location = new System.Drawing.Point(80, 7);
            this.BtnFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(76, 23);
            this.BtnFile.TabIndex = 2;
            this.BtnFile.Text = "FILE";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // LblFile
            // 
            this.LblFile.AutoSize = true;
            this.LblFile.Location = new System.Drawing.Point(4, 10);
            this.LblFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFile.Name = "LblFile";
            this.LblFile.Size = new System.Drawing.Size(78, 17);
            this.LblFile.TabIndex = 1;
            this.LblFile.Text = "Select File :";
            // 
            // LstMail
            // 
            this.LstMail.FormattingEnabled = true;
            this.LstMail.ItemHeight = 17;
            this.LstMail.Location = new System.Drawing.Point(-4, 33);
            this.LstMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LstMail.Name = "LstMail";
            this.LstMail.Size = new System.Drawing.Size(296, 429);
            this.LstMail.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.CheckEncode);
            this.tabPage2.Controls.Add(this.BtnRight);
            this.tabPage2.Controls.Add(this.BtnCenter);
            this.tabPage2.Controls.Add(this.BtnLeft);
            this.tabPage2.Controls.Add(this.CheckHtml);
            this.tabPage2.Controls.Add(this.BtnClf);
            this.tabPage2.Controls.Add(this.BtnClr);
            this.tabPage2.Controls.Add(this.TxtFile);
            this.tabPage2.Controls.Add(this.BtnAttach);
            this.tabPage2.Controls.Add(this.BtnUnder);
            this.tabPage2.Controls.Add(this.BtnItalic);
            this.tabPage2.Controls.Add(this.BtnStrike);
            this.tabPage2.Controls.Add(this.BtnBold);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.CmbSize);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.CmbStyle);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TxtSbj);
            this.tabPage2.Controls.Add(this.RichTextBox1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(770, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BODY";
            // 
            // CheckEncode
            // 
            this.CheckEncode.AutoSize = true;
            this.CheckEncode.Location = new System.Drawing.Point(617, 48);
            this.CheckEncode.Name = "CheckEncode";
            this.CheckEncode.Size = new System.Drawing.Size(114, 20);
            this.CheckEncode.TabIndex = 21;
            this.CheckEncode.Text = "TextEncoder";
            this.CheckEncode.UseVisualStyleBackColor = true;
            this.CheckEncode.CheckedChanged += new System.EventHandler(this.CheckEncode_CheckedChanged);
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(586, 41);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(25, 29);
            this.BtnRight.TabIndex = 20;
            this.BtnRight.Text = "R";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnCenter
            // 
            this.BtnCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCenter.Location = new System.Drawing.Point(555, 41);
            this.BtnCenter.Name = "BtnCenter";
            this.BtnCenter.Size = new System.Drawing.Size(25, 29);
            this.BtnCenter.TabIndex = 19;
            this.BtnCenter.Text = "C";
            this.BtnCenter.UseVisualStyleBackColor = true;
            this.BtnCenter.Click += new System.EventHandler(this.BtnCenter_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(524, 41);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(25, 29);
            this.BtnLeft.TabIndex = 18;
            this.BtnLeft.Text = "L";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // CheckHtml
            // 
            this.CheckHtml.AutoSize = true;
            this.CheckHtml.Location = new System.Drawing.Point(12, 47);
            this.CheckHtml.Name = "CheckHtml";
            this.CheckHtml.Size = new System.Drawing.Size(57, 20);
            this.CheckHtml.TabIndex = 17;
            this.CheckHtml.Text = "Html";
            this.CheckHtml.UseVisualStyleBackColor = true;
            // 
            // BtnClf
            // 
            this.BtnClf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClf.Location = new System.Drawing.Point(706, 9);
            this.BtnClf.Name = "BtnClf";
            this.BtnClf.Size = new System.Drawing.Size(52, 23);
            this.BtnClf.TabIndex = 16;
            this.BtnClf.Text = "Clear";
            this.BtnClf.UseVisualStyleBackColor = true;
            this.BtnClf.Click += new System.EventHandler(this.BtnClf_Click);
            // 
            // BtnClr
            // 
            this.BtnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClr.Location = new System.Drawing.Point(344, 10);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.Size = new System.Drawing.Size(75, 23);
            this.BtnClr.TabIndex = 15;
            this.BtnClr.Text = "Color";
            this.BtnClr.UseVisualStyleBackColor = true;
            this.BtnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // TxtFile
            // 
            this.TxtFile.Location = new System.Drawing.Point(483, 10);
            this.TxtFile.Name = "TxtFile";
            this.TxtFile.ReadOnly = true;
            this.TxtFile.Size = new System.Drawing.Size(217, 22);
            this.TxtFile.TabIndex = 14;
            // 
            // BtnAttach
            // 
            this.BtnAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAttach.Location = new System.Drawing.Point(425, 10);
            this.BtnAttach.Name = "BtnAttach";
            this.BtnAttach.Size = new System.Drawing.Size(52, 23);
            this.BtnAttach.TabIndex = 13;
            this.BtnAttach.Text = "File";
            this.BtnAttach.UseVisualStyleBackColor = true;
            this.BtnAttach.Click += new System.EventHandler(this.BtnAttach_Click);
            // 
            // BtnUnder
            // 
            this.BtnUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnder.Location = new System.Drawing.Point(494, 43);
            this.BtnUnder.Name = "BtnUnder";
            this.BtnUnder.Size = new System.Drawing.Size(24, 23);
            this.BtnUnder.TabIndex = 12;
            this.BtnUnder.Text = "U";
            this.BtnUnder.UseVisualStyleBackColor = true;
            this.BtnUnder.Click += new System.EventHandler(this.BtnUnder_Click);
            // 
            // BtnItalic
            // 
            this.BtnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItalic.Location = new System.Drawing.Point(434, 43);
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.Size = new System.Drawing.Size(24, 23);
            this.BtnItalic.TabIndex = 11;
            this.BtnItalic.Text = "I";
            this.BtnItalic.UseVisualStyleBackColor = true;
            this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click);
            // 
            // BtnStrike
            // 
            this.BtnStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStrike.Location = new System.Drawing.Point(464, 43);
            this.BtnStrike.Name = "BtnStrike";
            this.BtnStrike.Size = new System.Drawing.Size(24, 23);
            this.BtnStrike.TabIndex = 10;
            this.BtnStrike.Text = "A";
            this.BtnStrike.UseVisualStyleBackColor = true;
            this.BtnStrike.Click += new System.EventHandler(this.BtnStrike_Click);
            // 
            // BtnBold
            // 
            this.BtnBold.Location = new System.Drawing.Point(404, 43);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(24, 23);
            this.BtnBold.TabIndex = 9;
            this.BtnBold.Text = "B";
            this.BtnBold.UseVisualStyleBackColor = true;
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Size:";
            // 
            // CmbSize
            // 
            this.CmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSize.FormattingEnabled = true;
            this.CmbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.CmbSize.Location = new System.Drawing.Point(325, 44);
            this.CmbSize.Name = "CmbSize";
            this.CmbSize.Size = new System.Drawing.Size(73, 24);
            this.CmbSize.TabIndex = 7;
            this.CmbSize.SelectedIndexChanged += new System.EventHandler(this.CmbSize_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Style:";
            // 
            // CmbStyle
            // 
            this.CmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStyle.FormattingEnabled = true;
            this.CmbStyle.Location = new System.Drawing.Point(126, 43);
            this.CmbStyle.Name = "CmbStyle";
            this.CmbStyle.Size = new System.Drawing.Size(148, 24);
            this.CmbStyle.TabIndex = 5;
            this.CmbStyle.SelectedIndexChanged += new System.EventHandler(this.CmbStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            // 
            // TxtSbj
            // 
            this.TxtSbj.Location = new System.Drawing.Point(77, 10);
            this.TxtSbj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSbj.Name = "TxtSbj";
            this.TxtSbj.Size = new System.Drawing.Size(260, 22);
            this.TxtSbj.TabIndex = 2;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox1.Location = new System.Drawing.Point(0, 73);
            this.RichTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBox1.ShowSelectionMargin = true;
            this.RichTextBox1.Size = new System.Drawing.Size(769, 389);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            this.RichTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.BtnSmtp);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.CheckSsl);
            this.tabPage3.Controls.Add(this.TxtPort);
            this.tabPage3.Controls.Add(this.TxtPass);
            this.tabPage3.Controls.Add(this.TxtName);
            this.tabPage3.Controls.Add(this.TxtUser);
            this.tabPage3.Controls.Add(this.TxtHost);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(770, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SETTINGS";
            // 
            // BtnSmtp
            // 
            this.BtnSmtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSmtp.Location = new System.Drawing.Point(133, 385);
            this.BtnSmtp.Name = "BtnSmtp";
            this.BtnSmtp.Size = new System.Drawing.Size(75, 23);
            this.BtnSmtp.TabIndex = 13;
            this.BtnSmtp.Text = "Clear";
            this.BtnSmtp.UseVisualStyleBackColor = true;
            this.BtnSmtp.Click += new System.EventHandler(this.BtnSmtp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Number of Send";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(133, 325);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckSsl
            // 
            this.CheckSsl.AutoSize = true;
            this.CheckSsl.Location = new System.Drawing.Point(265, 255);
            this.CheckSsl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckSsl.Name = "CheckSsl";
            this.CheckSsl.Size = new System.Drawing.Size(54, 20);
            this.CheckSsl.TabIndex = 10;
            this.CheckSsl.Text = "SSL";
            this.CheckSsl.UseVisualStyleBackColor = true;
            this.CheckSsl.CheckedChanged += new System.EventHandler(this.CheckSsl_CheckedChanged);
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(98, 253);
            this.TxtPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(144, 22);
            this.TxtPort.TabIndex = 9;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(98, 191);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(438, 22);
            this.TxtPass.TabIndex = 8;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(98, 134);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(438, 22);
            this.TxtName.TabIndex = 7;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(98, 76);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(438, 22);
            this.TxtUser.TabIndex = 6;
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(98, 26);
            this.TxtHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(438, 22);
            this.TxtHost.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Port :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Pass :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "User :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Host :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 491);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmokyMailerPro";
            this.tabControl1.ResumeLayout(false);
            this.TabMail.ResumeLayout(false);
            this.TabMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabMail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Label LblFile;
        private System.Windows.Forms.ListBox LstMail;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSbj;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckSsl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbStyle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbSize;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnBold;
        private System.Windows.Forms.Button BtnStrike;
        private System.Windows.Forms.Button BtnItalic;
        private System.Windows.Forms.Button BtnUnder;
        private System.Windows.Forms.Button BtnAttach;
        private System.Windows.Forms.TextBox TxtFile;
        private System.Windows.Forms.Button BtnSmtp;
        private System.Windows.Forms.Button BtnClr;
        private System.Windows.Forms.TextBox TxtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox CheckHtml;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnCenter;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.CheckBox CheckEncode;
    }
}


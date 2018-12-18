namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rdiobtnKirmizi = new System.Windows.Forms.RadioButton();
            this.rdiobtnMavi = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnElleBelirleme = new System.Windows.Forms.RadioButton();
            this.rdiobtnYesil = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkKoordinatiGoster = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.baglan = new System.Windows.Forms.Button();
            this.bagkes = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rdiobtnTekCisimTakibi = new System.Windows.Forms.RadioButton();
            this.tool = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolS = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(50, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 418);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(472, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(348, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kamera Bölümü";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(23, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdiobtnKirmizi
            // 
            this.rdiobtnKirmizi.AutoSize = true;
            this.rdiobtnKirmizi.Location = new System.Drawing.Point(8, 19);
            this.rdiobtnKirmizi.Name = "rdiobtnKirmizi";
            this.rdiobtnKirmizi.Size = new System.Drawing.Size(54, 17);
            this.rdiobtnKirmizi.TabIndex = 6;
            this.rdiobtnKirmizi.TabStop = true;
            this.rdiobtnKirmizi.Text = "Kırmızı";
            this.rdiobtnKirmizi.UseVisualStyleBackColor = true;
            // 
            // rdiobtnMavi
            // 
            this.rdiobtnMavi.AutoSize = true;
            this.rdiobtnMavi.Location = new System.Drawing.Point(8, 65);
            this.rdiobtnMavi.Name = "rdiobtnMavi";
            this.rdiobtnMavi.Size = new System.Drawing.Size(51, 17);
            this.rdiobtnMavi.TabIndex = 7;
            this.rdiobtnMavi.TabStop = true;
            this.rdiobtnMavi.Text = "Mavi ";
            this.rdiobtnMavi.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(707, 339);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(106, 27);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nesne Kordinatı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnElleBelirleme);
            this.groupBox3.Controls.Add(this.rdiobtnYesil);
            this.groupBox3.Controls.Add(this.rdiobtnKirmizi);
            this.groupBox3.Controls.Add(this.rdiobtnMavi);
            this.groupBox3.Location = new System.Drawing.Point(166, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 114);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Renkler";
            // 
            // rdbtnElleBelirleme
            // 
            this.rdbtnElleBelirleme.AutoSize = true;
            this.rdbtnElleBelirleme.Location = new System.Drawing.Point(8, 88);
            this.rdbtnElleBelirleme.Name = "rdbtnElleBelirleme";
            this.rdbtnElleBelirleme.Size = new System.Drawing.Size(75, 17);
            this.rdbtnElleBelirleme.TabIndex = 24;
            this.rdbtnElleBelirleme.TabStop = true;
            this.rdbtnElleBelirleme.Text = "Sen Belirle";
            this.rdbtnElleBelirleme.UseVisualStyleBackColor = true;
            // 
            // rdiobtnYesil
            // 
            this.rdiobtnYesil.AutoSize = true;
            this.rdiobtnYesil.Location = new System.Drawing.Point(8, 42);
            this.rdiobtnYesil.Name = "rdiobtnYesil";
            this.rdiobtnYesil.Size = new System.Drawing.Size(50, 17);
            this.rdiobtnYesil.TabIndex = 8;
            this.rdiobtnYesil.TabStop = true;
            this.rdiobtnYesil.Text = "Yeşil ";
            this.rdiobtnYesil.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "B";
            // 
            // chkKoordinatiGoster
            // 
            this.chkKoordinatiGoster.AutoSize = true;
            this.chkKoordinatiGoster.Location = new System.Drawing.Point(715, 300);
            this.chkKoordinatiGoster.Name = "chkKoordinatiGoster";
            this.chkKoordinatiGoster.Size = new System.Drawing.Size(99, 17);
            this.chkKoordinatiGoster.TabIndex = 27;
            this.chkKoordinatiGoster.Text = "Kordinat Göster\r\n";
            this.chkKoordinatiGoster.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "255";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "0";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(115, 291);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 165);
            this.trackBar3.TabIndex = 23;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(73, 291);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 165);
            this.trackBar2.TabIndex = 22;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(33, 291);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 165);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // baglan
            // 
            this.baglan.Location = new System.Drawing.Point(567, 311);
            this.baglan.Margin = new System.Windows.Forms.Padding(2);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(98, 26);
            this.baglan.TabIndex = 34;
            this.baglan.Text = "Bağlan";
            this.baglan.UseVisualStyleBackColor = true;
            this.baglan.Click += new System.EventHandler(this.baglan_Click);
            // 
            // bagkes
            // 
            this.bagkes.Location = new System.Drawing.Point(567, 353);
            this.bagkes.Margin = new System.Windows.Forms.Padding(2);
            this.bagkes.Name = "bagkes";
            this.bagkes.Size = new System.Drawing.Size(98, 39);
            this.bagkes.TabIndex = 35;
            this.bagkes.Text = "Bağlantı Kes";
            this.bagkes.UseVisualStyleBackColor = true;
            this.bagkes.Click += new System.EventHandler(this.bagkes_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.comboBox2.Location = new System.Drawing.Point(557, 418);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 21);
            this.comboBox2.TabIndex = 34;
            // 
            // rdiobtnTekCisimTakibi
            // 
            this.rdiobtnTekCisimTakibi.AutoSize = true;
            this.rdiobtnTekCisimTakibi.Location = new System.Drawing.Point(725, 277);
            this.rdiobtnTekCisimTakibi.Name = "rdiobtnTekCisimTakibi";
            this.rdiobtnTekCisimTakibi.Size = new System.Drawing.Size(88, 17);
            this.rdiobtnTekCisimTakibi.TabIndex = 8;
            this.rdiobtnTekCisimTakibi.TabStop = true;
            this.rdiobtnTekCisimTakibi.Text = "Nesne Takibi";
            this.rdiobtnTekCisimTakibi.UseVisualStyleBackColor = true;
            // 
            // tool
            // 
            this.tool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolS});
            this.tool.Location = new System.Drawing.Point(0, 482);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(845, 25);
            this.tool.TabIndex = 39;
            this.tool.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolS
            // 
            this.toolS.Name = "toolS";
            this.toolS.Size = new System.Drawing.Size(0, 22);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ardiuno Bölümü";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(845, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rdiobtnTekCisimTakibi);
            this.Controls.Add(this.bagkes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.baglan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkKoordinatiGoster);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdiobtnKirmizi;
        private System.Windows.Forms.RadioButton rdiobtnMavi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdiobtnYesil;
        private System.Windows.Forms.RadioButton rdbtnElleBelirleme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkKoordinatiGoster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button bagkes;
        private System.Windows.Forms.Button baglan;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rdiobtnTekCisimTakibi;
        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolS;
        private System.Windows.Forms.Label label2;
    }
}


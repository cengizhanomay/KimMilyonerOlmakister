namespace Kim_Milyoner_Olmak_İster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.form1şarkı = new AxWMPLib.AxWindowsMediaPlayer();
            this.grpyazı = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txbbilgi = new System.Windows.Forms.TextBox();
            this.grpyazı1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.form1şarkı)).BeginInit();
            this.grpyazı.SuspendLayout();
            this.grpyazı1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Kim_Milyoner_Olmak_İster.Properties.Resources.başla;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(202, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 51);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Kim_Milyoner_Olmak_İster.Properties.Resources.hakkında;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(552, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 52);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Kim_Milyoner_Olmak_İster.Properties.Resources.yardım;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(0, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 52);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Kim_Milyoner_Olmak_İster.Properties.Resources.çıkış;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(202, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(358, 55);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // form1şarkı
            // 
            this.form1şarkı.Enabled = true;
            this.form1şarkı.Location = new System.Drawing.Point(680, 12);
            this.form1şarkı.Name = "form1şarkı";
            this.form1şarkı.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("form1şarkı.OcxState")));
            this.form1şarkı.Size = new System.Drawing.Size(75, 23);
            this.form1şarkı.TabIndex = 4;
            this.form1şarkı.Visible = false;
            // 
            // grpyazı
            // 
            this.grpyazı.BackColor = System.Drawing.Color.Wheat;
            this.grpyazı.Controls.Add(this.button5);
            this.grpyazı.Controls.Add(this.txbbilgi);
            this.grpyazı.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpyazı.Location = new System.Drawing.Point(543, 2);
            this.grpyazı.Name = "grpyazı";
            this.grpyazı.Size = new System.Drawing.Size(505, 277);
            this.grpyazı.TabIndex = 5;
            this.grpyazı.TabStop = false;
            this.grpyazı.Text = "Hakkımızda";
            this.grpyazı.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(306, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "Tamam";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txbbilgi
            // 
            this.txbbilgi.Enabled = false;
            this.txbbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbbilgi.Location = new System.Drawing.Point(6, 48);
            this.txbbilgi.Multiline = true;
            this.txbbilgi.Name = "txbbilgi";
            this.txbbilgi.Size = new System.Drawing.Size(493, 223);
            this.txbbilgi.TabIndex = 0;
            this.txbbilgi.Text = "Oyunu Yapan Kişinin;\r\nAdı : Cengizhan\r\nSoyadı : Omay\r\nE-Posta Adresi : cengizhano" +
    "may@outlook.com\r\nTelefon No : 0507 532 ** **";
            // 
            // grpyazı1
            // 
            this.grpyazı1.BackColor = System.Drawing.Color.Wheat;
            this.grpyazı1.Controls.Add(this.button6);
            this.grpyazı1.Controls.Add(this.textBox1);
            this.grpyazı1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpyazı1.Location = new System.Drawing.Point(0, 2);
            this.grpyazı1.Name = "grpyazı1";
            this.grpyazı1.Size = new System.Drawing.Size(537, 388);
            this.grpyazı1.TabIndex = 6;
            this.grpyazı1.TabStop = false;
            this.grpyazı1.Text = "Yardım";
            this.grpyazı1.Visible = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(352, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = "Tamam";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(6, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 334);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kim_Milyoner_Olmak_İster.Properties.Resources.milyonerbaşla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 433);
            this.Controls.Add(this.grpyazı);
            this.Controls.Add(this.grpyazı1);
            this.Controls.Add(this.form1şarkı);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1şarkı)).EndInit();
            this.grpyazı.ResumeLayout(false);
            this.grpyazı.PerformLayout();
            this.grpyazı1.ResumeLayout(false);
            this.grpyazı1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private AxWMPLib.AxWindowsMediaPlayer form1şarkı;
        private System.Windows.Forms.GroupBox grpyazı;
        private System.Windows.Forms.TextBox txbbilgi;
        private System.Windows.Forms.GroupBox grpyazı1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}


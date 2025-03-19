namespace DictionaryApp
{
    partial class FrmDic
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
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEnglish = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(630, 55);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.picSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(323, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 112);
            this.panel1.TabIndex = 4;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picSearch.Image = global::DictionaryApp.Properties.Resources.R;
            this.picSearch.Location = new System.Drawing.Point(554, 33);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(79, 50);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 3;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1306, 126);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dictionary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbEnglish
            // 
            this.lbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnglish.Location = new System.Drawing.Point(316, 249);
            this.lbEnglish.Name = "lbEnglish";
            this.lbEnglish.Size = new System.Drawing.Size(152, 65);
            this.lbEnglish.TabIndex = 6;
            this.lbEnglish.Text = "Hello";
            this.lbEnglish.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "/həˈləʊ/";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "exclamtion,noun";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DictionaryApp.Properties.Resources._905555;
            this.pictureBox1.Location = new System.Drawing.Point(323, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Beige;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(313, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(640, 68);
            this.label4.TabIndex = 10;
            this.label4.Text = "Xin Chào ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Beige;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(316, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(990, 49);
            this.label6.TabIndex = 12;
            this.label6.Text = "She answered the phone with a cheerful \"Hello!\"";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Beige;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(316, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(990, 49);
            this.label5.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Beige;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(319, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(990, 49);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hello! How have you been?";
            // 
            // FrmDic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1306, 763);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello! How have you been?";
            this.Load += new System.EventHandler(this.FrmDic_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEnglish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}


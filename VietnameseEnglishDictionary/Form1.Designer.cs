namespace VietnameseEnglishDictionary
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
            this.label1 = new System.Windows.Forms.Label();
            this.roundedTextBox1 = new VietnameseEnglishDictionary.RoundedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "DICTIONARY";
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.roundedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.roundedTextBox1.Location = new System.Drawing.Point(3, 1);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.roundedTextBox1.Size = new System.Drawing.Size(463, 66);
            this.roundedTextBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.roundedTextBox1);
            this.panel1.Location = new System.Drawing.Point(179, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 70);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundedTextBox roundedTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


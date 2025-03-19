using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietnameseEnglishDictionary
{
    public partial class RoundedTextBox : UserControl
    {
        private TextBox textBox;
        private int cornerRadius = 15;
        public RoundedTextBox()
        {
            //InitializeComponent();
            textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
            textBox.Location = new Point(10, 5);
            textBox.Width = this.Width - 20;
            textBox.Height = this.Height - 10;

            this.Controls.Add(textBox);
            this.Padding = new Padding(5);
            this.Size = new Size(200, 30);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            this.Resize += RoundedTextBox_Resize;
            textBox.TextChanged += (s, e) => this.Invalidate();
        }

       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                int arcSize = cornerRadius * 2;
                path.AddArc(0, 0, arcSize, arcSize, 180, 90);
                path.AddArc(this.Width - arcSize, 0, arcSize, arcSize, 270, 90);
                path.AddArc(this.Width - arcSize, this.Height - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(0, this.Height - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
                g.FillPath(new SolidBrush(this.BackColor), path);
            }
        }

        private void RoundedTextBox_Resize(object sender, EventArgs e)
        {
            textBox.Width = this.Width - 20;
            textBox.Height = this.Height - 10;
        }
        public string TextValue
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
    }
}

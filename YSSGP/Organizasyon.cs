using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YSSGP
{
    public partial class Organizasyon : Form
    {
        public Organizasyon()
        {
            InitializeComponent();
        }
        Graphics gr;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            gr = e.Graphics;

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            Label lbl = sender as Label;
            gr.DrawString(lbl.Text, new Font(SystemFonts.DefaultFont, FontStyle.Regular), Brushes.Aqua, 0, 0);

        }

        private void Organizasyon_Load(object sender, EventArgs e)
        {
           // gr = e.Graphics;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            Font f = new Font(FontFamily.GenericSansSerif, 12.0f);
            Brush b = Brushes.Aqua;
            Pen p = new Pen(b);

            //gr.DrawString(lbl.Text, f, b, new PointF(0.0f, 0.0f));
            gr.DrawLine(p, new Point(0, 0), new Point(10, 10));
        }
    }
}

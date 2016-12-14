using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTree
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen drawingPen = Pens.Black;
        float gWidth;
        float gHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawFractalTree();
        }

        private void angleTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void lengthTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void DrawFractalTree()
        {
            g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);

            gWidth = g.VisibleClipBounds.Width;
            gHeight = g.VisibleClipBounds.Height;

            Branch(100);
            /*
            float length = 100;
            g.DrawLine(drawingPen, gWidth / 2, gHeight, gWidth / 2, gHeight - length);
            */

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            DrawFractalTree();
        }

        private void Branch(float length)
        {

            g.DrawLine(drawingPen, gWidth / 2, gHeight, gWidth / 2, gHeight - length);
        }


    }
}

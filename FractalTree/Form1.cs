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
            g.TranslateTransform(gWidth / 2, gHeight);
            Branch(200);
            g.TranslateTransform(-(gWidth / 2), -(gHeight));

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            DrawFractalTree();
        }

        private void Branch(float length)
        {
            g.DrawLine(drawingPen, 0, 0, 0, -length);
            g.TranslateTransform(0, -length);
            if (length > 4)
            {
                g.RotateTransform(45);
                Branch(length * .75F);
                g.RotateTransform(-45);
                g.RotateTransform(-45);
                Branch(length * .75F);
                g.RotateTransform(45);
            }
            g.TranslateTransform(0, length);
        }


    }
}

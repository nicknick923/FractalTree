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
    public partial class ChildBranchEditor : Form
    {
        private Branch b;
        private Graphics panelGraphics;
        private Graphics bitmapGraphics;
        private Bitmap drawingImage;
        public ChildBranchEditor(Branch inBranch)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            b = inBranch;
            panelGraphics = panel1.CreateGraphics();

            recursionLengthTrackBar.Value = (int)(b.getRecLength() * 100);
            angleTrackBar.Value = b.getAngle();
        }

        private void ChildBranchEditor_Shown(object sender, EventArgs e)
        {
        }

        private void updateDrawing()
        {
            drawingImage = new Bitmap(panel1.Size.Width, panel1.Size.Height);
            bitmapGraphics = Graphics.FromImage(drawingImage);
            //bitmapGraphics.Clear(Color.Gray);
            b.DrawBranchInEditor(bitmapGraphics);
            panelGraphics.DrawImage(drawingImage, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            updateDrawing();
        }

        private void recursionLengthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            b = new Branch(b.getAngle(), (float)recursionLengthTrackBar.Value / 100);
            panel1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //updateDrawing();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FractalTree.Options;

namespace FractalTree
{
    public partial class ChildBranchEditor : Form
    {
        private Branch b;
        private Graphics panelGraphics;
        private Graphics bitmapGraphics;
        public event VisualUpdateHandler VisualUpdateEvent;
        private Bitmap drawingImage;
        public event NumberUpdateHandler NumberUpdate;
        public ChildBranchEditor(Branch inBranch)
        {
            InitializeComponent();
            b = inBranch;
            panelGraphics = panel1.CreateGraphics();

            recursionLengthTrackBar.Value = (int)(b.GetRecLength() * 100);
            angleTrackBar.Value = b.GetAngle();
        }

        private void UpdateDrawing()
        {
            drawingImage = new Bitmap(panel1.Size.Width, panel1.Size.Height);
            bitmapGraphics = Graphics.FromImage(drawingImage);
            b.DrawBranchInEditor(bitmapGraphics);
            panelGraphics.DrawImage(drawingImage, 0, 0);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            UpdateDrawing();
        }

        private void RecursionLengthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            b.ChangeCharacteristics(b.GetAngle(), (float)recursionLengthTrackBar.Value / 100);
            panel1.Invalidate();
            CallNumberUpdate();
            label9.Text = recursionLengthTrackBar.Value + "%";
            if (liveUpdateCheckBox.Checked)
                VisualUpdateEvent();

        }

        private void CallNumberUpdate()
        {
            NumberUpdate?.Invoke();
        }

        private void RefreshFullTreeButton_Click(object sender, EventArgs e)
        {
            VisualUpdateEvent();
        }

        private void AngleTrackBar_ValueChanged(object sender, EventArgs e)
        {
            b.ChangeCharacteristics(angleTrackBar.Value, b.GetRecLength());
            panel1.Invalidate();
            CallNumberUpdate();
            label6.Text = angleTrackBar.Value + "°";
            if (liveUpdateCheckBox.Checked)
                VisualUpdateEvent();
        }

        private void PropertyTrackBarKeyUp(object sender, KeyEventArgs e)
        {
            if (liveUpdateCheckBox.Checked)
                VisualUpdateEvent();
        }

        private void PropertyTrackBarMouseUp(object sender, MouseEventArgs e)
        {
            if (liveUpdateCheckBox.Checked)
                VisualUpdateEvent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

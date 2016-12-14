﻿using System;
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
        public event NumberUpdateHandler numberUpdate;
        public ChildBranchEditor(Branch inBranch)
        {
            InitializeComponent();
            b = inBranch;
            panelGraphics = panel1.CreateGraphics();

            recursionLengthTrackBar.Value = (int)(b.getRecLength() * 100);
            angleTrackBar.Value = b.getAngle();
        }

        private void updateDrawing()
        {
            drawingImage = new Bitmap(panel1.Size.Width, panel1.Size.Height);
            bitmapGraphics = Graphics.FromImage(drawingImage);
            b.DrawBranchInEditor(bitmapGraphics);
            panelGraphics.DrawImage(drawingImage, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            updateDrawing();
        }

        private void recursionLengthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            b.changeCharacteristics(b.getAngle(), (float)recursionLengthTrackBar.Value / 100);
            panel1.Invalidate();
            callNumberUpdate();
            if (liveUpdateCheckBox.Checked)
                VisualUpdateEvent();

        }

        private void callNumberUpdate()
        {
            if (numberUpdate != null)
            {
                numberUpdate();
            }
        }

        private void refreshFullTreeButton_Click(object sender, EventArgs e)
        {
            VisualUpdateEvent();
        }

        private void angleTrackBar_ValueChanged(object sender, EventArgs e)
        {
            b.changeCharacteristics(angleTrackBar.Value, b.getRecLength());
            panel1.Invalidate();
            callNumberUpdate();
            if (liveUpdateCheckBox.Checked)
                VisualUpdateEvent();
        }

        private void propertyTrackBarKeyUp(object sender, KeyEventArgs e)
        {
            if (liveUpdateCheckBox.Checked)
                VisualUpdateEvent();
        }

        private void propertyTrackBarMouseUp(object sender, MouseEventArgs e)
        {
            if (liveUpdateCheckBox.Checked)
                VisualUpdateEvent();
        }
    }
}

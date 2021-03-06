﻿using System;
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
    public partial class FractalTree : Form
    {
        Bitmap bm;
        Graphics g;
        Pen drawingPen = Pens.Black;
        float gWidth;
        float gHeight;
        BackgroundWorker drawer = new BackgroundWorker();
        ToolTip t = new ToolTip();
        Options optionsForm = new Options();

        private int initialLength;

        public FractalTree()
        {
            InitializeComponent();
            drawer.WorkerSupportsCancellation = true;
            drawer.WorkerReportsProgress = false;
            drawer.DoWork += Drawer_DoWork;
            drawer.RunWorkerCompleted += Drawer_RunWorkerCompleted;
            initialLength = lengthTrackBar.Value;
            optionsForm.CallUpdate += OptionsForm_callUpdate;
        }

        private void OptionsForm_callUpdate()
        {
            Button1_Click(null, null);
        }

        private void Drawer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button1.Text = "Draw";
        }

        private void Drawer_DoWork(object sender, DoWorkEventArgs e)
        {
            DrawFractalTree(e);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Button1_Click(null, null);
        }

        private void DrawFractalTree(DoWorkEventArgs e)
        {
            bm = new Bitmap(panel1.Size.Width, panel1.Size.Height);
            g = Graphics.FromImage(bm);
            gWidth = g.VisibleClipBounds.Width;
            gHeight = g.VisibleClipBounds.Height;
            g.Clear(panel1.BackColor);

            g.TranslateTransform(gWidth / 2, gHeight);
            DrawBranch(initialLength, e);
            g.TranslateTransform(-(gWidth / 2), -(gHeight));

            panel1.CreateGraphics().DrawImage(bm, 0, 0);

        }

        private void DrawBranch(int length, DoWorkEventArgs e)
        {
            if (drawer.CancellationPending)
                e.Cancel = true;
            else
            {
                g.DrawLine(drawingPen, 0, 0, 0, -length);
                g.TranslateTransform(0, -length);
                if (length > 4)
                    foreach (Branch b in optionsForm.GetBranches())
                    {
                        g.RotateTransform(b.GetAngle());
                        DrawBranch((int)(length * b.GetRecLength()), e);
                        g.RotateTransform(-b.GetAngle());
                    }
                g.TranslateTransform(0, length);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!drawer.IsBusy)
            {
                initialLength = lengthTrackBar.Value;
                button1.Text = "Cancel";
                drawer.RunWorkerAsync();
            }
            else
                drawer.CancelAsync();
        }

        private void LengthTrackBar_MouseHover(object sender, EventArgs e)
        {
            t.Hide(this);
            t.Show("Use this slider to set the length of the trunk.", this, lengthTrackBar.Location.X + 20, lengthTrackBar.Location.Y, 2500);
        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
            Button1_Click(null, null);
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionsForm.Show();
        }
    }
}

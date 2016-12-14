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
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        Pen drawingPen = Pens.Black;
        float gWidth;
        float gHeight;
        BackgroundWorker drawer = new BackgroundWorker();
        ToolTip t = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            drawer.WorkerSupportsCancellation = true;
            drawer.WorkerReportsProgress = false;
            drawer.DoWork += Drawer_DoWork;
        }

        private void Drawer_DoWork(object sender, DoWorkEventArgs e)
        {
            button1.Text = "Cancel";
            DrawFractalTree(e);
            button1.Text = "Draw";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void DrawFractalTree(DoWorkEventArgs e)
        {
            bm = new Bitmap(panel1.Size.Width, panel1.Size.Height);
            //g = panel1.CreateGraphics();
            g = Graphics.FromImage(bm);
            gWidth = g.VisibleClipBounds.Width;
            gHeight = g.VisibleClipBounds.Height;
            g.Clear(panel1.BackColor);


            g.TranslateTransform(gWidth / 2, gHeight);
            Branch(lengthTrackBar.Value, e);
            g.TranslateTransform(-(gWidth / 2), -(gHeight));

            panel1.CreateGraphics().DrawImage(bm, 0,0);

        }



        private void panel1_Click(object sender, EventArgs e)
        {
        }

        private void Branch(float length, DoWorkEventArgs e)
        {
            if (drawer.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                g.DrawLine(drawingPen, 0, 0, 0, -length);
                g.TranslateTransform(0, -length);
                if (length > 4)
                {
                    g.RotateTransform(angleTrackBar.Value);
                    Branch(length * recursionLengthTrackBar.Value / 100, e);
                    g.RotateTransform(-angleTrackBar.Value);
                    g.RotateTransform(.15F*-angleTrackBar.Value);
                    Branch(length * recursionLengthTrackBar.Value / 100, e);
                    g.RotateTransform(.15F*angleTrackBar.Value);
                }
                g.TranslateTransform(0, length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!drawer.IsBusy)
                drawer.RunWorkerAsync();
            else
                drawer.CancelAsync();
        }

        private void angleTrackBar_MouseHover(object sender, EventArgs e)
        {
            t.Hide(this);
            t.Show("Use this slider to set the angle that the branches should extend in.", this, angleTrackBar.Location.X + 20, angleTrackBar.Location.Y, 2500);
        }

        private void lengthTrackBar_MouseHover(object sender, EventArgs e)
        {
            t.Hide(this);
            t.Show("Use this slider to set the length of the trunk.", this, lengthTrackBar.Location.X + 20, lengthTrackBar.Location.Y, 2500);
        }

        private void recursionLengthTrackBar_MouseHover(object sender, EventArgs e)
        {
            t.Hide(this);
            t.Show("Use this slider to set the recursiveness of the branches.", this, recursionLengthTrackBar.Location.X + 20, recursionLengthTrackBar.Location.Y, 2500);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void value1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

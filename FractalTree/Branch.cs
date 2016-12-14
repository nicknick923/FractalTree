﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalTree
{
    public class Branch
    {
        private int angleFromParent;
        private float recLength;

        public Branch(int inAngle, float recursiveLength)
        {
            angleFromParent = inAngle;
            recLength = recursiveLength;
        }

        public void DrawBranchInEditor(Graphics g)
        {
            Pen drawingPen = Pens.Black;
            float gWidth = g.VisibleClipBounds.Width;
            float gHeight = g.VisibleClipBounds.Height;
            int length = 50;
            g.TranslateTransform(gWidth / 2, gHeight);
            g.DrawLine(drawingPen, 0, 0, 0, -length);
            g.TranslateTransform(0, -length);
            g.TranslateTransform(0, -length);
            g.RotateTransform(getAngle());
            length = (int)(length * getRecLength());
            g.DrawLine(drawingPen, 0, 0, 0, -length);
        }

        public int getAngle()
        {
            return angleFromParent;
        }

        public float getRecLength()
        {
            return recLength;
        }

        public override String ToString()
        {
            return "Angle: " + angleFromParent + " Recursive Length: " + recLength;
        }//test


    }
}

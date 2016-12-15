using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalTree
{
    public class Branch
    {
        private int angle;
        private float recLength;


        public Branch(int inAngle, float recursiveLength)
        {
            angle = inAngle;
            recLength = recursiveLength;
        }

        public void DrawBranchInEditor(Graphics g)
        {
            Pen drawingPen = Pens.Black;
            Pen emphasisPen = Pens.Blue;
            float gWidth = g.VisibleClipBounds.Width;
            float gHeight = g.VisibleClipBounds.Height;
            int length = (int)gHeight/2;
            g.TranslateTransform(gWidth / 2, gHeight);
            g.DrawLine(drawingPen, 0, 0, 0, -length);
            g.TranslateTransform(0, -length);
            g.RotateTransform(GetAngle());
            length = (int)(length * GetRecLength());
            g.DrawLine(emphasisPen, 0, 0, 0, -length);
        }

        public int GetAngle()
        {
            return angle;
        }

        public void ChangeCharacteristics(int inAngle, float inRecLength)
        {
            angle = inAngle;
            recLength = inRecLength;
        }


        public float GetRecLength()
        {
            return recLength;
        }

        public override String ToString()
        {
            return "Angle: " + angle.ToString().PadLeft(6) + "° Recursive Length: " + (recLength*100).ToString().PadLeft(5) + "%";
        }
    }
}

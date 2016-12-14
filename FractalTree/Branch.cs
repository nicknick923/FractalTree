using System;
using System.Collections.Generic;
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
        }

    }
}

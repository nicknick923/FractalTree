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
        private Graphics g;
        public ChildBranchEditor(Branch inBranch)
        {
            InitializeComponent();
            b = inBranch;
            g = panel1.CreateGraphics();
        }

        private void ChildBranchEditor_Shown(object sender, EventArgs e)
        {
            updateDrawing();
        }

        private void updateDrawing()
        {
            g.Clear(Color.Gray);
            b.DrawBranchInEditor(g);
        }
    }
}

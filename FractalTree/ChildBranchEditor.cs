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
    public partial class ChildBranchEditor : Form
    {
        Branch b;
        public ChildBranchEditor(ref Branch inBranch)
        {
            InitializeComponent();
            b = inBranch;
            b.DrawBranchInEditor(panel1.CreateGraphics());
        }


    }
}

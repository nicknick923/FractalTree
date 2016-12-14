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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            listBox1.Items.Add(new Branch(10, .75F));
            listBox1.Items.Add(new Branch(-45, .75F));
            listBox1.Items.Add(new Branch(0, .50F));
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editBranchButton.Enabled = listBox1.SelectedIndex != -1;
            removeBranchButton.Enabled = listBox1.SelectedIndex != -1;
        }

        public List<Branch> GetBranches()
        {
            List<Branch> listOfBranches = new List<Branch>();
            foreach (Object o in listBox1.Items)
                if (o.GetType() == typeof(Branch))
                    listOfBranches.Add((Branch)o);
            return listOfBranches;
        }



        private void addBranchButton_Click(object sender, EventArgs e)
        {

        }

        private void editBranchButton_Click(object sender, EventArgs e)
        {
            ChildBranchEditor cbe = new ChildBranchEditor((Branch)listBox1.SelectedItem);
            cbe.Show();
        }

        private void removeBranchButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}

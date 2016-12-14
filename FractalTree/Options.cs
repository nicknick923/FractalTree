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
        private GrowableArray<Branch> listOfBranches = new GrowableArray<Branch>();

        public Options()
        {
            InitializeComponent();
            listOfBranches.Add(new Branch(10, .75F));
            listOfBranches.Add(new Branch(-45, .75F));
            listOfBranches.Add(new Branch(0, .50F));
            updateListBox();
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public void updateListBox()
        {
            listBox1.Items.Clear();
            foreach (Branch b in listOfBranches)
                listBox1.Items.Add(b);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            int selectedIndex = listBox1.SelectedIndex;
            ChildBranchEditor cbe = new ChildBranchEditor(ref listOfBranches.ElementAt(selectedIndex));
            cbe.Show();
        }

        private void removeBranchButton_Click(object sender, EventArgs e)
        {
            listOfBranches.RemoveItem((Branch)listBox1.SelectedItem);
            updateListBox();
        }
    }
}

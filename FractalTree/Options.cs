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
        public delegate void VisualUpdateHandler();
        public delegate void NumberUpdateHandler();
        public event VisualUpdateHandler callUpdate;
        public Options()
        {
            InitializeComponent();
            listBox1.Items.Add(new Branch(10, .75F));
            listBox1.Items.Add(new Branch(-45, .75F));
            listBox1.Items.Add(new Branch(0, .50F));
            listBox1_SelectedIndexChanged(null, null);
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
            foreach (Branch b in listBox1.Items)
                    listOfBranches.Add(b);
            return listOfBranches;
        }



        private void addBranchButton_Click(object sender, EventArgs e)
        {
            Branch b = new Branch(0, .5F);
            listBox1.Items.Add(b);
            CreateChildBranchEditor(b);
        }

        private void editBranchButton_Click(object sender, EventArgs e)
        {
            CreateChildBranchEditor((Branch)listBox1.SelectedItem);
        }

        private void CreateChildBranchEditor(Branch b)
        {
            ChildBranchEditor cbe = new ChildBranchEditor(b);
            cbe.Show();
            cbe.VisualUpdateEvent += ChildBranchEditorUpdateCall;
            cbe.numberUpdate += ChildBranchEditorNumberUpdate;
        }

        private void ChildBranchEditorNumberUpdate()
        {
            UpdateToString(listBox1);
        }

        private void UpdateToString(ListBox listBox)
        {
            int count = listBox.Items.Count;
            listBox.SuspendLayout();
            for (int i = 0; i < count; i++)
                listBox.Items[i] = listBox.Items[i];
            listBox.ResumeLayout();
        }

        private void ChildBranchEditorUpdateCall()
        {
            callUpdate();
        }

        private void removeBranchButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}

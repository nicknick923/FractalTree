namespace FractalTree
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBranchButton = new System.Windows.Forms.Button();
            this.removeBranchButton = new System.Windows.Forms.Button();
            this.editBranchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Of Child Branches";
            // 
            // addBranchButton
            // 
            this.addBranchButton.Location = new System.Drawing.Point(12, 243);
            this.addBranchButton.Name = "addBranchButton";
            this.addBranchButton.Size = new System.Drawing.Size(266, 23);
            this.addBranchButton.TabIndex = 2;
            this.addBranchButton.Text = "Add Branch";
            this.addBranchButton.UseVisualStyleBackColor = true;
            this.addBranchButton.Click += new System.EventHandler(this.addBranchButton_Click);
            // 
            // removeBranchButton
            // 
            this.removeBranchButton.Location = new System.Drawing.Point(12, 301);
            this.removeBranchButton.Name = "removeBranchButton";
            this.removeBranchButton.Size = new System.Drawing.Size(266, 23);
            this.removeBranchButton.TabIndex = 3;
            this.removeBranchButton.Text = "Remove Branch";
            this.removeBranchButton.UseVisualStyleBackColor = true;
            this.removeBranchButton.Click += new System.EventHandler(this.removeBranchButton_Click);
            // 
            // editBranchButton
            // 
            this.editBranchButton.Location = new System.Drawing.Point(12, 272);
            this.editBranchButton.Name = "editBranchButton";
            this.editBranchButton.Size = new System.Drawing.Size(266, 23);
            this.editBranchButton.TabIndex = 4;
            this.editBranchButton.Text = "Edit Branch";
            this.editBranchButton.UseVisualStyleBackColor = true;
            this.editBranchButton.Click += new System.EventHandler(this.editBranchButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 332);
            this.Controls.Add(this.editBranchButton);
            this.Controls.Add(this.removeBranchButton);
            this.Controls.Add(this.addBranchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBranchButton;
        private System.Windows.Forms.Button removeBranchButton;
        private System.Windows.Forms.Button editBranchButton;
    }
}
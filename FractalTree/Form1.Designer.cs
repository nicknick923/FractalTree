namespace FractalTree
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.angleTrackBar = new System.Windows.Forms.TrackBar();
            this.lengthTrackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.recursionLengthTrackBar = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.value1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursionLengthTrackBar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.angleTrackBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lengthTrackBar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.recursionLengthTrackBar, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 394);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // angleTrackBar
            // 
            this.angleTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.angleTrackBar.Location = new System.Drawing.Point(3, 356);
            this.angleTrackBar.Maximum = 180;
            this.angleTrackBar.Name = "angleTrackBar";
            this.angleTrackBar.Size = new System.Drawing.Size(198, 35);
            this.angleTrackBar.TabIndex = 0;
            this.angleTrackBar.TickFrequency = 10;
            this.angleTrackBar.Value = 45;
            this.angleTrackBar.MouseHover += new System.EventHandler(this.angleTrackBar_MouseHover);
            // 
            // lengthTrackBar
            // 
            this.lengthTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lengthTrackBar.Location = new System.Drawing.Point(207, 356);
            this.lengthTrackBar.Maximum = 250;
            this.lengthTrackBar.Minimum = 20;
            this.lengthTrackBar.Name = "lengthTrackBar";
            this.lengthTrackBar.Size = new System.Drawing.Size(198, 35);
            this.lengthTrackBar.TabIndex = 1;
            this.lengthTrackBar.TickFrequency = 25;
            this.lengthTrackBar.Value = 100;
            this.lengthTrackBar.MouseHover += new System.EventHandler(this.lengthTrackBar_MouseHover);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 347);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(615, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recursionLengthTrackBar
            // 
            this.recursionLengthTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.recursionLengthTrackBar.Location = new System.Drawing.Point(411, 356);
            this.recursionLengthTrackBar.Maximum = 100;
            this.recursionLengthTrackBar.Minimum = 1;
            this.recursionLengthTrackBar.Name = "recursionLengthTrackBar";
            this.recursionLengthTrackBar.Size = new System.Drawing.Size(198, 35);
            this.recursionLengthTrackBar.TabIndex = 4;
            this.recursionLengthTrackBar.TickFrequency = 10;
            this.recursionLengthTrackBar.Value = 67;
            this.recursionLengthTrackBar.MouseHover += new System.EventHandler(this.recursionLengthTrackBar_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.value1ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // value1ToolStripMenuItem
            // 
            this.value1ToolStripMenuItem.Name = "value1ToolStripMenuItem";
            this.value1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.value1ToolStripMenuItem.Text = "More Options";
            this.value1ToolStripMenuItem.Click += new System.EventHandler(this.value1ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursionLengthTrackBar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar angleTrackBar;
        private System.Windows.Forms.TrackBar lengthTrackBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar recursionLengthTrackBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem value1ToolStripMenuItem;
    }
}


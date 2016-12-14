namespace FractalTree
{
    partial class ChildBranchEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.angleTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.recursionLengthTrackBar = new System.Windows.Forms.TrackBar();
            this.refreshFullTreeButton = new System.Windows.Forms.Button();
            this.liveUpdateCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursionLengthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 166);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // angleTrackBar
            // 
            this.angleTrackBar.LargeChange = 10;
            this.angleTrackBar.Location = new System.Drawing.Point(12, 89);
            this.angleTrackBar.Maximum = 170;
            this.angleTrackBar.Minimum = -170;
            this.angleTrackBar.Name = "angleTrackBar";
            this.angleTrackBar.Size = new System.Drawing.Size(195, 45);
            this.angleTrackBar.TabIndex = 1;
            this.angleTrackBar.TickFrequency = 10;
            this.angleTrackBar.ValueChanged += new System.EventHandler(this.AngleTrackBar_ValueChanged);
            this.angleTrackBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PropertyTrackBarKeyUp);
            this.angleTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PropertyTrackBarMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "-170°";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "170°";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "0°";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Angle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Recursion Length";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "90%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "10%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recursionLengthTrackBar
            // 
            this.recursionLengthTrackBar.LargeChange = 10;
            this.recursionLengthTrackBar.Location = new System.Drawing.Point(12, 25);
            this.recursionLengthTrackBar.Maximum = 90;
            this.recursionLengthTrackBar.Minimum = 10;
            this.recursionLengthTrackBar.Name = "recursionLengthTrackBar";
            this.recursionLengthTrackBar.Size = new System.Drawing.Size(195, 45);
            this.recursionLengthTrackBar.TabIndex = 6;
            this.recursionLengthTrackBar.TickFrequency = 10;
            this.recursionLengthTrackBar.Value = 10;
            this.recursionLengthTrackBar.ValueChanged += new System.EventHandler(this.RecursionLengthTrackBar_ValueChanged);
            this.recursionLengthTrackBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PropertyTrackBarKeyUp);
            this.recursionLengthTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PropertyTrackBarMouseUp);
            // 
            // refreshFullTreeButton
            // 
            this.refreshFullTreeButton.Location = new System.Drawing.Point(12, 312);
            this.refreshFullTreeButton.Name = "refreshFullTreeButton";
            this.refreshFullTreeButton.Size = new System.Drawing.Size(105, 23);
            this.refreshFullTreeButton.TabIndex = 11;
            this.refreshFullTreeButton.Text = "Refresh Full Tree";
            this.refreshFullTreeButton.UseVisualStyleBackColor = true;
            this.refreshFullTreeButton.Click += new System.EventHandler(this.RefreshFullTreeButton_Click);
            // 
            // liveUpdateCheckBox
            // 
            this.liveUpdateCheckBox.AutoSize = true;
            this.liveUpdateCheckBox.Location = new System.Drawing.Point(123, 316);
            this.liveUpdateCheckBox.Name = "liveUpdateCheckBox";
            this.liveUpdateCheckBox.Size = new System.Drawing.Size(84, 17);
            this.liveUpdateCheckBox.TabIndex = 12;
            this.liveUpdateCheckBox.Text = "Live Update";
            this.liveUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChildBranchEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 341);
            this.Controls.Add(this.liveUpdateCheckBox);
            this.Controls.Add(this.refreshFullTreeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.recursionLengthTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angleTrackBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChildBranchEditor";
            this.Text = "Branch Editor";
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursionLengthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar angleTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar recursionLengthTrackBar;
        private System.Windows.Forms.Button refreshFullTreeButton;
        private System.Windows.Forms.CheckBox liveUpdateCheckBox;
    }
}
namespace TrianglesFiller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            drawingPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            alphaValueLabel = new Label();
            label4 = new Label();
            betaValueLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            betaTrackBar = new TrackBar();
            alphaTrackBar = new TrackBar();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            mValueLabel = new Label();
            kdValueLabel = new Label();
            ksValueLabel = new Label();
            kdTrackBar = new TrackBar();
            mTrackBar = new TrackBar();
            ksTrackBar = new TrackBar();
            colorButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)betaTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alphaTrackBar).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kdTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ksTrackBar).BeginInit();
            SuspendLayout();
            // 
            // drawingPanel
            // 
            drawingPanel.BackColor = SystemColors.AppWorkspace;
            drawingPanel.BorderStyle = BorderStyle.FixedSingle;
            drawingPanel.Dock = DockStyle.Fill;
            drawingPanel.Location = new Point(3, 3);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(647, 527);
            drawingPanel.TabIndex = 0;
            drawingPanel.Paint += drawingPanel_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 338F));
            tableLayoutPanel1.Controls.Add(drawingPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(991, 533);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(colorButton, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(656, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 127F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(332, 527);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(alphaValueLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(betaValueLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(betaTrackBar);
            groupBox1.Controls.Add(alphaTrackBar);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Angles";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // alphaValueLabel
            // 
            alphaValueLabel.AutoSize = true;
            alphaValueLabel.Location = new Point(133, 23);
            alphaValueLabel.Name = "alphaValueLabel";
            alphaValueLabel.Size = new Size(17, 20);
            alphaValueLabel.TabIndex = 6;
            alphaValueLabel.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 23);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            // 
            // betaValueLabel
            // 
            betaValueLabel.AutoSize = true;
            betaValueLabel.Location = new Point(292, 23);
            betaValueLabel.Name = "betaValueLabel";
            betaValueLabel.Size = new Size(17, 20);
            betaValueLabel.TabIndex = 4;
            betaValueLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 23);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "Beta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 23);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 2;
            label1.Text = "Alpha";
            // 
            // betaTrackBar
            // 
            betaTrackBar.Location = new Point(170, 46);
            betaTrackBar.Name = "betaTrackBar";
            betaTrackBar.Size = new Size(150, 56);
            betaTrackBar.TabIndex = 1;
            betaTrackBar.Scroll += betaTrackBar_Scroll;
            // 
            // alphaTrackBar
            // 
            alphaTrackBar.LargeChange = 15;
            alphaTrackBar.Location = new Point(0, 46);
            alphaTrackBar.Maximum = 45;
            alphaTrackBar.Minimum = -45;
            alphaTrackBar.Name = "alphaTrackBar";
            alphaTrackBar.Size = new Size(150, 56);
            alphaTrackBar.SmallChange = 5;
            alphaTrackBar.TabIndex = 0;
            alphaTrackBar.TickFrequency = 5;
            alphaTrackBar.Scroll += alphaTrackBar_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(mValueLabel);
            groupBox2.Controls.Add(kdValueLabel);
            groupBox2.Controls.Add(ksValueLabel);
            groupBox2.Controls.Add(kdTrackBar);
            groupBox2.Controls.Add(mTrackBar);
            groupBox2.Controls.Add(ksTrackBar);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 214);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Coefficients";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 28);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 12;
            label9.Text = "kd";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 28);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 11;
            label8.Text = "kd";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 110);
            label7.Name = "label7";
            label7.Size = new Size(22, 20);
            label7.TabIndex = 10;
            label7.Text = "m";
            // 
            // mValueLabel
            // 
            mValueLabel.AutoSize = true;
            mValueLabel.Location = new Point(128, 110);
            mValueLabel.Name = "mValueLabel";
            mValueLabel.Size = new Size(25, 20);
            mValueLabel.TabIndex = 9;
            mValueLabel.Text = "50";
            // 
            // kdValueLabel
            // 
            kdValueLabel.AutoSize = true;
            kdValueLabel.Location = new Point(295, 28);
            kdValueLabel.Name = "kdValueLabel";
            kdValueLabel.Size = new Size(28, 20);
            kdValueLabel.TabIndex = 8;
            kdValueLabel.Text = "0.5";
            kdValueLabel.Click += label5_Click;
            // 
            // ksValueLabel
            // 
            ksValueLabel.AutoSize = true;
            ksValueLabel.Location = new Point(128, 28);
            ksValueLabel.Name = "ksValueLabel";
            ksValueLabel.Size = new Size(28, 20);
            ksValueLabel.TabIndex = 7;
            ksValueLabel.Text = "0.5";
            // 
            // kdTrackBar
            // 
            kdTrackBar.Location = new Point(170, 51);
            kdTrackBar.Maximum = 100;
            kdTrackBar.Name = "kdTrackBar";
            kdTrackBar.Size = new Size(150, 56);
            kdTrackBar.TabIndex = 3;
            kdTrackBar.TickFrequency = 5;
            kdTrackBar.Value = 50;
            kdTrackBar.Scroll += kdTrackBar_Scroll;
            // 
            // mTrackBar
            // 
            mTrackBar.Location = new Point(6, 133);
            mTrackBar.Maximum = 100;
            mTrackBar.Minimum = 1;
            mTrackBar.Name = "mTrackBar";
            mTrackBar.Size = new Size(150, 56);
            mTrackBar.TabIndex = 2;
            mTrackBar.TickFrequency = 5;
            mTrackBar.Value = 50;
            mTrackBar.Scroll += mTrackBar_Scroll;
            // 
            // ksTrackBar
            // 
            ksTrackBar.Location = new Point(6, 51);
            ksTrackBar.Maximum = 100;
            ksTrackBar.Name = "ksTrackBar";
            ksTrackBar.Size = new Size(150, 56);
            ksTrackBar.TabIndex = 1;
            ksTrackBar.TickFrequency = 5;
            ksTrackBar.Value = 50;
            ksTrackBar.Scroll += ksTrackBar_Scroll;
            // 
            // colorButton
            // 
            colorButton.Location = new Point(3, 350);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(99, 29);
            colorButton.TabIndex = 2;
            colorButton.Text = "Select color";
            colorButton.UseVisualStyleBackColor = true;
            colorButton.Click += colorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 533);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)betaTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)alphaTrackBar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kdTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)mTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ksTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel drawingPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private Label alphaValueLabel;
        private Label label4;
        private Label betaValueLabel;
        private Label label2;
        private Label label1;
        private TrackBar betaTrackBar;
        private TrackBar alphaTrackBar;
        private GroupBox groupBox2;
        private Label mValueLabel;
        private Label kdValueLabel;
        private Label ksValueLabel;
        private TrackBar kdTrackBar;
        private TrackBar mTrackBar;
        private TrackBar ksTrackBar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button colorButton;
    }
}

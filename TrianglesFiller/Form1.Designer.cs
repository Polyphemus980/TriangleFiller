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
            groupBox3 = new GroupBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            fillRadio = new RadioButton();
            meshRadio = new RadioButton();
            sampleCountLabel = new Label();
            label5 = new Label();
            sampleSizeTrackBar = new TrackBar();
            colorButton = new Button();
            groupBox1 = new GroupBox();
            alphaValueLabel = new Label();
            label4 = new Label();
            betaValueLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            betaTrackBar = new TrackBar();
            alphaTrackBar = new TrackBar();
            groupBox2 = new GroupBox();
            ZValueLabel = new Label();
            ZTrackBar = new TrackBar();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            mValueLabel = new Label();
            kdValueLabel = new Label();
            ksValueLabel = new Label();
            kdTrackBar = new TrackBar();
            mTrackBar = new TrackBar();
            ksTrackBar = new TrackBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sampleSizeTrackBar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)betaTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alphaTrackBar).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ZTrackBar).BeginInit();
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
            drawingPanel.Size = new Size(647, 571);
            drawingPanel.TabIndex = 0;
            drawingPanel.Paint += drawingPanel_Paint;
            drawingPanel.Resize += drawingPanel_Resize;
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
            tableLayoutPanel1.Size = new Size(991, 577);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(656, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 127F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(332, 571);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(fillRadio);
            groupBox3.Controls.Add(meshRadio);
            groupBox3.Controls.Add(sampleCountLabel);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(sampleSizeTrackBar);
            groupBox3.Controls.Add(colorButton);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 350);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 218);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Other";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(161, 99);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(140, 24);
            checkBox2.TabIndex = 22;
            checkBox2.Text = "Use normal map";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(6, 121);
            button1.Name = "button1";
            button1.Size = new Size(99, 35);
            button1.TabIndex = 21;
            button1.Text = "Load map";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(161, 69);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 24);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Moving light source";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // fillRadio
            // 
            fillRadio.AutoSize = true;
            fillRadio.Checked = true;
            fillRadio.Location = new Point(6, 91);
            fillRadio.Name = "fillRadio";
            fillRadio.Size = new Size(139, 24);
            fillRadio.TabIndex = 19;
            fillRadio.TabStop = true;
            fillRadio.Text = "Draw filling only";
            fillRadio.UseVisualStyleBackColor = true;
            fillRadio.CheckedChanged += fillRadio_CheckedChanged;
            // 
            // meshRadio
            // 
            meshRadio.AutoSize = true;
            meshRadio.Location = new Point(6, 61);
            meshRadio.Name = "meshRadio";
            meshRadio.Size = new Size(136, 24);
            meshRadio.TabIndex = 18;
            meshRadio.Text = "Draw mesh only";
            meshRadio.UseVisualStyleBackColor = true;
            meshRadio.CheckedChanged += meshRadio_CheckedChanged;
            // 
            // sampleCountLabel
            // 
            sampleCountLabel.AutoSize = true;
            sampleCountLabel.Location = new Point(286, 14);
            sampleCountLabel.Name = "sampleCountLabel";
            sampleCountLabel.Size = new Size(25, 20);
            sampleCountLabel.TabIndex = 17;
            sampleCountLabel.Text = "20";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 14);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 15;
            label5.Text = "Sample size";
            // 
            // sampleSizeTrackBar
            // 
            sampleSizeTrackBar.Location = new Point(161, 37);
            sampleSizeTrackBar.Maximum = 200;
            sampleSizeTrackBar.Minimum = 5;
            sampleSizeTrackBar.Name = "sampleSizeTrackBar";
            sampleSizeTrackBar.Size = new Size(150, 56);
            sampleSizeTrackBar.TabIndex = 3;
            sampleSizeTrackBar.TickFrequency = 5;
            sampleSizeTrackBar.Value = 20;
            sampleSizeTrackBar.Scroll += sampleSizeTrackBar_Scroll;
            // 
            // colorButton
            // 
            colorButton.Location = new Point(6, 26);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(147, 29);
            colorButton.TabIndex = 2;
            colorButton.Text = "Select object color";
            colorButton.UseVisualStyleBackColor = true;
            colorButton.Click += colorButton_Click;
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
            groupBox2.Controls.Add(ZValueLabel);
            groupBox2.Controls.Add(ZTrackBar);
            groupBox2.Controls.Add(label3);
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
            // ZValueLabel
            // 
            ZValueLabel.AutoSize = true;
            ZValueLabel.Location = new Point(270, 110);
            ZValueLabel.Name = "ZValueLabel";
            ZValueLabel.Size = new Size(33, 20);
            ZValueLabel.TabIndex = 16;
            ZValueLabel.Text = "250";
            // 
            // ZTrackBar
            // 
            ZTrackBar.Location = new Point(181, 133);
            ZTrackBar.Maximum = 500;
            ZTrackBar.Minimum = 50;
            ZTrackBar.Name = "ZTrackBar";
            ZTrackBar.Size = new Size(130, 56);
            ZTrackBar.TabIndex = 15;
            ZTrackBar.Value = 250;
            ZTrackBar.Scroll += ZTrackBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 110);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 14;
            label3.Text = "source Z";
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
            label8.Size = new Size(22, 20);
            label8.TabIndex = 11;
            label8.Text = "ks";
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
            // button2
            // 
            button2.Location = new Point(161, 129);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 23;
            button2.Text = "Select light color";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 577);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sampleSizeTrackBar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)betaTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)alphaTrackBar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ZTrackBar).EndInit();
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
        private TrackBar ZTrackBar;
        private Label label3;
        private Label ZValueLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox3;
        private Label sampleCountLabel;
        private Label label5;
        private TrackBar sampleSizeTrackBar;
        private RadioButton fillRadio;
        private RadioButton meshRadio;
        private CheckBox checkBox1;
        private Button button1;
        private CheckBox checkBox2;
        private Button button2;
    }
}

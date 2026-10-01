namespace SegregateCoins
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorThresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.rangeThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.processButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fivePesoThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.onePesoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.twentyFiveCentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tenCentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CoinsDetected = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorThresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePesoThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePesoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(205, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // colorThresholdTrackBar
            // 
            this.colorThresholdTrackBar.Location = new System.Drawing.Point(80, 463);
            this.colorThresholdTrackBar.Maximum = 255;
            this.colorThresholdTrackBar.Name = "colorThresholdTrackBar";
            this.colorThresholdTrackBar.Size = new System.Drawing.Size(712, 69);
            this.colorThresholdTrackBar.TabIndex = 1;
            this.colorThresholdTrackBar.Value = 150;
            // 
            // rangeThresholdNumericUpDown
            // 
            this.rangeThresholdNumericUpDown.Location = new System.Drawing.Point(87, 538);
            this.rangeThresholdNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rangeThresholdNumericUpDown.Name = "rangeThresholdNumericUpDown";
            this.rangeThresholdNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.rangeThresholdNumericUpDown.TabIndex = 2;
            this.rangeThresholdNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(633, 176);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(134, 62);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Range Threshold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chance";
            // 
            // chanceNumericUpDown
            // 
            this.chanceNumericUpDown.Location = new System.Drawing.Point(233, 538);
            this.chanceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.chanceNumericUpDown.Name = "chanceNumericUpDown";
            this.chanceNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.chanceNumericUpDown.TabIndex = 10;
            this.chanceNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "5 Peso";
            // 
            // fivePesoThresholdNumericUpDown
            // 
            this.fivePesoThresholdNumericUpDown.Location = new System.Drawing.Point(374, 538);
            this.fivePesoThresholdNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fivePesoThresholdNumericUpDown.Name = "fivePesoThresholdNumericUpDown";
            this.fivePesoThresholdNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.fivePesoThresholdNumericUpDown.TabIndex = 12;
            this.fivePesoThresholdNumericUpDown.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.fivePesoThresholdNumericUpDown.ValueChanged += new System.EventHandler(this.fivePesoThresholdNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "1 Peso";
            // 
            // onePesoNumericUpDown
            // 
            this.onePesoNumericUpDown.Location = new System.Drawing.Point(512, 538);
            this.onePesoNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.onePesoNumericUpDown.Name = "onePesoNumericUpDown";
            this.onePesoNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.onePesoNumericUpDown.TabIndex = 14;
            this.onePesoNumericUpDown.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.onePesoNumericUpDown.ValueChanged += new System.EventHandler(this.onePesoNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "25 cent";
            // 
            // twentyFiveCentNumericUpDown
            // 
            this.twentyFiveCentNumericUpDown.Location = new System.Drawing.Point(653, 538);
            this.twentyFiveCentNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.twentyFiveCentNumericUpDown.Name = "twentyFiveCentNumericUpDown";
            this.twentyFiveCentNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.twentyFiveCentNumericUpDown.TabIndex = 16;
            this.twentyFiveCentNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.twentyFiveCentNumericUpDown.ValueChanged += new System.EventHandler(this.twentyFiveCentNumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(798, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "10 cent";
            // 
            // tenCentNumericUpDown
            // 
            this.tenCentNumericUpDown.Location = new System.Drawing.Point(779, 538);
            this.tenCentNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tenCentNumericUpDown.Name = "tenCentNumericUpDown";
            this.tenCentNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.tenCentNumericUpDown.TabIndex = 18;
            this.tenCentNumericUpDown.Value = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.tenCentNumericUpDown.ValueChanged += new System.EventHandler(this.tenCentNumericUpDown_ValueChanged);
            // 
            // CoinsDetected
            // 
            this.CoinsDetected.Location = new System.Drawing.Point(617, 288);
            this.CoinsDetected.Name = "CoinsDetected";
            this.CoinsDetected.Size = new System.Drawing.Size(166, 96);
            this.CoinsDetected.TabIndex = 19;
            this.CoinsDetected.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 783);
            this.Controls.Add(this.CoinsDetected);
            this.Controls.Add(this.tenCentNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.twentyFiveCentNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.onePesoNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fivePesoThresholdNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chanceNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.rangeThresholdNumericUpDown);
            this.Controls.Add(this.colorThresholdTrackBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorThresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePesoThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePesoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar colorThresholdTrackBar;
        private System.Windows.Forms.NumericUpDown rangeThresholdNumericUpDown;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown chanceNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown fivePesoThresholdNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown onePesoNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown twentyFiveCentNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tenCentNumericUpDown;
        private System.Windows.Forms.RichTextBox CoinsDetected;
    }
}


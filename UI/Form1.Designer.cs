namespace UI
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
            this.carPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.speedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentInfoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.NumericUpDown();
            this.info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.DarkGray;
            this.carPanel.Location = new System.Drawing.Point(12, 91);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(318, 254);
            this.carPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(112, 399);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 29);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // speedButton
            // 
            this.speedButton.Location = new System.Drawing.Point(12, 400);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(75, 26);
            this.speedButton.TabIndex = 2;
            this.speedButton.Text = "Set Speed";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Speed:";
            // 
            // currentInfoLabel
            // 
            this.currentInfoLabel.AutoSize = true;
            this.currentInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentInfoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentInfoLabel.Location = new System.Drawing.Point(570, 9);
            this.currentInfoLabel.Name = "currentInfoLabel";
            this.currentInfoLabel.Size = new System.Drawing.Size(0, 16);
            this.currentInfoLabel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(131, 437);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 29);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // speedBox
            // 
            this.speedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedBox.Location = new System.Drawing.Point(21, 441);
            this.speedBox.Name = "speedBox";
            this.speedBox.ReadOnly = true;
            this.speedBox.Size = new System.Drawing.Size(88, 22);
            this.speedBox.TabIndex = 8;
            this.speedBox.ValueChanged += new System.EventHandler(this.speedBox_ValueChanged);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.YellowGreen;
            this.info.Location = new System.Drawing.Point(187, 374);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 16);
            this.info.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(131, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 94);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(55, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 113);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(805, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 143);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(288, 389);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 85);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(487, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 94);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(56, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(71, 141);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Maroon;
            this.panel7.Location = new System.Drawing.Point(301, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(68, 157);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Maroon;
            this.panel8.Location = new System.Drawing.Point(533, 100);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(93, 141);
            this.panel8.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(895, 482);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.currentInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.carPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Car Animation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentInfoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
    }
}


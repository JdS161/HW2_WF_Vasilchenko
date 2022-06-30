namespace HW2_WF_Vasilchenko
{
    partial class TimerForm
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
            this.numericCounter = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelForTimer = new System.Windows.Forms.Label();
            this.labelCountdown = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // numericCounter
            // 
            this.numericCounter.Location = new System.Drawing.Point(123, 26);
            this.numericCounter.Margin = new System.Windows.Forms.Padding(2);
            this.numericCounter.Name = "numericCounter";
            this.numericCounter.Size = new System.Drawing.Size(47, 20);
            this.numericCounter.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(23, 105);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(56, 19);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(114, 105);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(56, 19);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelForTimer
            // 
            this.labelForTimer.AutoSize = true;
            this.labelForTimer.Location = new System.Drawing.Point(9, 28);
            this.labelForTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForTimer.Name = "labelForTimer";
            this.labelForTimer.Size = new System.Drawing.Size(99, 13);
            this.labelForTimer.TabIndex = 3;
            this.labelForTimer.Text = "Number of seconds";
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Location = new System.Drawing.Point(74, 72);
            this.labelCountdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(0, 13);
            this.labelCountdown.TabIndex = 4;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(83, 59);
            this.lblCountdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(25, 26);
            this.lblCountdown.TabIndex = 5;
            this.lblCountdown.Text = "0";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(42, 147);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 19);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Back to Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 177);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.labelCountdown);
            this.Controls.Add(this.labelForTimer);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericCounter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimerForm";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.numericCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelForTimer;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
    }
}
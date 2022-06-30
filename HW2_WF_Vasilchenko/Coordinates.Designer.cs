namespace HW2_WF_Vasilchenko
{
    partial class Coordinates
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
            this.panelExternal = new System.Windows.Forms.Panel();
            this.panelInternal = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelExternal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExternal
            // 
            this.panelExternal.BackColor = System.Drawing.Color.Transparent;
            this.panelExternal.Controls.Add(this.panelInternal);
            this.panelExternal.Controls.Add(this.buttonClose);
            this.panelExternal.Location = new System.Drawing.Point(0, 0);
            this.panelExternal.Name = "panelExternal";
            this.panelExternal.Size = new System.Drawing.Size(600, 366);
            this.panelExternal.TabIndex = 2;
            this.panelExternal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelExternal_MouseClick);
            this.panelExternal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelExternal_MouseMove);
            // 
            // panelInternal
            // 
            this.panelInternal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelInternal.Location = new System.Drawing.Point(100, 50);
            this.panelInternal.Name = "panelInternal";
            this.panelInternal.Size = new System.Drawing.Size(400, 200);
            this.panelInternal.TabIndex = 1;
            this.panelInternal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelInternal_MouseClick);
            this.panelInternal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelInternal_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(250, 300);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 33);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Main Menu";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Coordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelExternal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Coordinates";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelExternal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelInternal;
        private System.Windows.Forms.Panel panelExternal;
    }
}
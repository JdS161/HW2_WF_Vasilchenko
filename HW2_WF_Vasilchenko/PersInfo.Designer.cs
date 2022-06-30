namespace HW2_WF_Vasilchenko
{
    partial class PersInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCIty = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.maskedTbPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.dateTimeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPatronim = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxPatronim = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboBoxCIty);
            this.groupBox1.Controls.Add(this.comboBoxCountry);
            this.groupBox1.Controls.Add(this.maskedTbPhone);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.dateTimeBirthdate);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.labelPatronim);
            this.groupBox1.Controls.Add(this.labelGender);
            this.groupBox1.Controls.Add(this.textBoxPatronim);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.labelDOB);
            this.groupBox1.Controls.Add(this.labelCountry);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelCity);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(302, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // comboBoxCIty
            // 
            this.comboBoxCIty.FormattingEnabled = true;
            this.comboBoxCIty.Items.AddRange(new object[] {
            "Russia",
            "France",
            "China",
            "Germany",
            "USA",
            "UK"});
            this.comboBoxCIty.Location = new System.Drawing.Point(100, 140);
            this.comboBoxCIty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCIty.Name = "comboBoxCIty";
            this.comboBoxCIty.Size = new System.Drawing.Size(197, 21);
            this.comboBoxCIty.TabIndex = 34;
            this.comboBoxCIty.SelectedIndexChanged += new System.EventHandler(this.comboBoxCIty_SelectedIndexChanged);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Russia",
            "France",
            "China",
            "Germany",
            "USA",
            "UK"});
            this.comboBoxCountry.Location = new System.Drawing.Point(99, 115);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(197, 21);
            this.comboBoxCountry.TabIndex = 33;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // maskedTbPhone
            // 
            this.maskedTbPhone.Location = new System.Drawing.Point(100, 162);
            this.maskedTbPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTbPhone.Mask = "+7 (999) 000-0000";
            this.maskedTbPhone.Name = "maskedTbPhone";
            this.maskedTbPhone.Size = new System.Drawing.Size(196, 20);
            this.maskedTbPhone.TabIndex = 24;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(25, 54);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 16;
            this.labelFirstName.Text = "First Name:";
            // 
            // dateTimeBirthdate
            // 
            this.dateTimeBirthdate.Location = new System.Drawing.Point(100, 198);
            this.dateTimeBirthdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeBirthdate.Name = "dateTimeBirthdate";
            this.dateTimeBirthdate.Size = new System.Drawing.Size(196, 20);
            this.dateTimeBirthdate.TabIndex = 25;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(148, 221);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 28;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(100, 52);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(196, 20);
            this.textBoxFirstName.TabIndex = 18;
            // 
            // labelPatronim
            // 
            this.labelPatronim.AutoSize = true;
            this.labelPatronim.Location = new System.Drawing.Point(25, 77);
            this.labelPatronim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPatronim.Name = "labelPatronim";
            this.labelPatronim.Size = new System.Drawing.Size(51, 13);
            this.labelPatronim.TabIndex = 23;
            this.labelPatronim.Text = "Patronim:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(25, 221);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 32;
            this.labelGender.Text = "Gender";
            // 
            // textBoxPatronim
            // 
            this.textBoxPatronim.Location = new System.Drawing.Point(100, 75);
            this.textBoxPatronim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPatronim.Name = "textBoxPatronim";
            this.textBoxPatronim.Size = new System.Drawing.Size(196, 20);
            this.textBoxPatronim.TabIndex = 20;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(25, 32);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 26;
            this.labelLastName.Text = "Last Name:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(100, 221);
            this.rbMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 27;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(100, 29);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(196, 20);
            this.textBoxLastName.TabIndex = 17;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(25, 198);
            this.labelDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(69, 13);
            this.labelDOB.TabIndex = 31;
            this.labelDOB.Text = "Date of Birth:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(25, 122);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(46, 13);
            this.labelCountry.TabIndex = 19;
            this.labelCountry.Text = "Country:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(25, 167);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 30;
            this.labelPhone.Text = "Phone:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(25, 145);
            this.labelCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 29;
            this.labelCity.Text = "City:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(32, 281);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(56, 19);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 281);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 281);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 309);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PersInfo";
            this.Text = "Personal Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTbPhone;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.DateTimePicker dateTimeBirthdate;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPatronim;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxPatronim;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxCIty;
    }
}
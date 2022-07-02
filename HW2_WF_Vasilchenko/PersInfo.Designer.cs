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
            this.mTbPhoneCh = new System.Windows.Forms.MaskedTextBox();
            this.mTbPhoneUK = new System.Windows.Forms.MaskedTextBox();
            this.mTbPhoneGer = new System.Windows.Forms.MaskedTextBox();
            this.mTbPhoneFr = new System.Windows.Forms.MaskedTextBox();
            this.mTbPhoneUS = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCIty = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.mTbPhoneRu = new System.Windows.Forms.MaskedTextBox();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.mTbPhoneCh);
            this.groupBox1.Controls.Add(this.mTbPhoneUK);
            this.groupBox1.Controls.Add(this.mTbPhoneGer);
            this.groupBox1.Controls.Add(this.mTbPhoneFr);
            this.groupBox1.Controls.Add(this.mTbPhoneUS);
            this.groupBox1.Controls.Add(this.comboBoxCIty);
            this.groupBox1.Controls.Add(this.comboBoxCountry);
            this.groupBox1.Controls.Add(this.mTbPhoneRu);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // mTbPhoneCh
            // 
            this.mTbPhoneCh.Location = new System.Drawing.Point(150, 254);
            this.mTbPhoneCh.Mask = "+86-100-0000-0000";
            this.mTbPhoneCh.Name = "mTbPhoneCh";
            this.mTbPhoneCh.Size = new System.Drawing.Size(294, 26);
            this.mTbPhoneCh.TabIndex = 39;
            // 
            // mTbPhoneUK
            // 
            this.mTbPhoneUK.Location = new System.Drawing.Point(150, 254);
            this.mTbPhoneUK.Mask = "+44-0000-000000";
            this.mTbPhoneUK.Name = "mTbPhoneUK";
            this.mTbPhoneUK.Size = new System.Drawing.Size(294, 26);
            this.mTbPhoneUK.TabIndex = 38;
            // 
            // mTbPhoneGer
            // 
            this.mTbPhoneGer.Location = new System.Drawing.Point(150, 254);
            this.mTbPhoneGer.Mask = "+4\\9-000-0000-000";
            this.mTbPhoneGer.Name = "mTbPhoneGer";
            this.mTbPhoneGer.Size = new System.Drawing.Size(294, 26);
            this.mTbPhoneGer.TabIndex = 37;
            // 
            // mTbPhoneFr
            // 
            this.mTbPhoneFr.Location = new System.Drawing.Point(150, 254);
            this.mTbPhoneFr.Mask = "+33-9-99-00-00-00";
            this.mTbPhoneFr.Name = "mTbPhoneFr";
            this.mTbPhoneFr.Size = new System.Drawing.Size(294, 26);
            this.mTbPhoneFr.TabIndex = 36;
            // 
            // mTbPhoneUS
            // 
            this.mTbPhoneUS.Location = new System.Drawing.Point(150, 254);
            this.mTbPhoneUS.Mask = "+1-999-000-0000";
            this.mTbPhoneUS.Name = "mTbPhoneUS";
            this.mTbPhoneUS.Size = new System.Drawing.Size(294, 26);
            this.mTbPhoneUS.TabIndex = 35;
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
            this.comboBoxCIty.Location = new System.Drawing.Point(150, 215);
            this.comboBoxCIty.Name = "comboBoxCIty";
            this.comboBoxCIty.Size = new System.Drawing.Size(294, 28);
            this.comboBoxCIty.TabIndex = 34;
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
            this.comboBoxCountry.Location = new System.Drawing.Point(148, 177);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(294, 28);
            this.comboBoxCountry.TabIndex = 33;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // mTbPhoneRu
            // 
            this.mTbPhoneRu.Location = new System.Drawing.Point(150, 254);
            this.mTbPhoneRu.Mask = "+7 (999) 000-0000";
            this.mTbPhoneRu.Name = "mTbPhoneRu";
            this.mTbPhoneRu.Size = new System.Drawing.Size(294, 26);
            this.mTbPhoneRu.TabIndex = 24;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(38, 83);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(90, 20);
            this.labelFirstName.TabIndex = 16;
            this.labelFirstName.Text = "First Name:";
            // 
            // dateTimeBirthdate
            // 
            this.dateTimeBirthdate.Location = new System.Drawing.Point(150, 305);
            this.dateTimeBirthdate.Name = "dateTimeBirthdate";
            this.dateTimeBirthdate.Size = new System.Drawing.Size(292, 26);
            this.dateTimeBirthdate.TabIndex = 25;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(222, 340);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 28;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(150, 80);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(292, 26);
            this.textBoxFirstName.TabIndex = 18;
            // 
            // labelPatronim
            // 
            this.labelPatronim.AutoSize = true;
            this.labelPatronim.Location = new System.Drawing.Point(38, 118);
            this.labelPatronim.Name = "labelPatronim";
            this.labelPatronim.Size = new System.Drawing.Size(76, 20);
            this.labelPatronim.TabIndex = 23;
            this.labelPatronim.Text = "Patronim:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(38, 340);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 20);
            this.labelGender.TabIndex = 32;
            this.labelGender.Text = "Gender";
            // 
            // textBoxPatronim
            // 
            this.textBoxPatronim.Location = new System.Drawing.Point(150, 115);
            this.textBoxPatronim.Name = "textBoxPatronim";
            this.textBoxPatronim.Size = new System.Drawing.Size(292, 26);
            this.textBoxPatronim.TabIndex = 20;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(38, 49);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 20);
            this.labelLastName.TabIndex = 26;
            this.labelLastName.Text = "Last Name:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(150, 340);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 27;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(150, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(292, 26);
            this.textBoxLastName.TabIndex = 17;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(38, 305);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(103, 20);
            this.labelDOB.TabIndex = 31;
            this.labelDOB.Text = "Date of Birth:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(38, 188);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(68, 20);
            this.labelCountry.TabIndex = 19;
            this.labelCountry.Text = "Country:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(38, 257);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(59, 20);
            this.labelPhone.TabIndex = 30;
            this.labelPhone.Text = "Phone:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(38, 223);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(39, 20);
            this.labelCity.TabIndex = 29;
            this.labelCity.Text = "City:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(286, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 475);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PersInfo";
            this.Text = "Personal Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MaskedTextBox mTbPhoneRu;
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
        private System.Windows.Forms.MaskedTextBox mTbPhoneGer;
        private System.Windows.Forms.MaskedTextBox mTbPhoneFr;
        private System.Windows.Forms.MaskedTextBox mTbPhoneUS;
        private System.Windows.Forms.MaskedTextBox mTbPhoneCh;
        private System.Windows.Forms.MaskedTextBox mTbPhoneUK;
    }
}
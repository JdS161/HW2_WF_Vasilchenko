using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_WF_Vasilchenko
{
    public partial class PersInfo : Form
    {
        public PersInfo()
        {
            InitializeComponent();
        }

        string[] Rus_list = new string[]
        {
            "Moscow",
            "Rostov-on-Don",
            "Saint-Petersbourg",
            "Novosibirsk",
            "Krasnodar",
            "Sochi"
        };

        string[] Fr_list = new string[]
        {
            "Paris",
            "Lyon",
            "Marseille",
            "Dijon",
            "Lille",
            "Tarbes"
        };

        string[] Ch_list = new string[]
        {
            "Beijing",
            "Datong",
            "Guangzhou",
            "Chengdu",
            "Shanghai",
            "Zhengzhou"
        };

        string[] Ger_list = new string[]
        {
            "Berlin",
            "Dortmund",
            "Koeln",
            "Muenich",
            "Frankfurt-am-Mein",
            "Wiesbaden"
        };

        string[] USA_list = new string[]
        {
            "Washington",
            "San-Francisco",
            "Detroit",
            "New York",
            "New Jersey",
            "Austin"
        };

        string[] UK_list = new string[]
        {
            "London",
            "Manchester",
            "Birmingham",
            "Edinburgh",
            "Liverpool",
            "Glasgow"
        };


        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int city = comboBoxCountry.SelectedIndex;

            switch (city)
            {
                case 0:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(Rus_list);
                    mTbPhoneRu.Visible = true;
                    mTbPhoneCh.Visible = false;
                    mTbPhoneFr.Visible = false;
                    mTbPhoneGer.Visible = false;
                    mTbPhoneUK.Visible = false;
                    mTbPhoneUS.Visible = false;
                    break;
                case 1:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(Fr_list);
                    mTbPhoneRu.Visible = false;
                    mTbPhoneCh.Visible = false;
                    mTbPhoneFr.Visible = true;
                    mTbPhoneGer.Visible = false;
                    mTbPhoneUK.Visible = false;
                    mTbPhoneUS.Visible = false;
                    break;
                case 2:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(Ch_list);
                    mTbPhoneRu.Visible = false;
                    mTbPhoneCh.Visible = true;
                    mTbPhoneFr.Visible = false;
                    mTbPhoneGer.Visible = false;
                    mTbPhoneUK.Visible = false;
                    mTbPhoneUS.Visible = false;
                    break;
                case 3:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(Ger_list);
                    mTbPhoneRu.Visible = false;
                    mTbPhoneCh.Visible = false;
                    mTbPhoneFr.Visible = false;
                    mTbPhoneGer.Visible = true;
                    mTbPhoneUK.Visible = false;
                    mTbPhoneUS.Visible = false;
                    break;
                case 4:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(USA_list);
                    mTbPhoneRu.Visible = false;
                    mTbPhoneCh.Visible = false;
                    mTbPhoneFr.Visible = false;
                    mTbPhoneGer.Visible = false;
                    mTbPhoneUK.Visible = false;
                    mTbPhoneUS.Visible = true;
                    break;
                case 5:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(UK_list);
                    mTbPhoneRu.Visible = false;
                    mTbPhoneCh.Visible = false;
                    mTbPhoneFr.Visible = false;
                    mTbPhoneGer.Visible = false;
                    mTbPhoneUK.Visible = true;
                    mTbPhoneUS.Visible = false;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || 
                textBoxLastName.Text == "" || 
                comboBoxCIty.Text=="" || 
                comboBoxCountry.Text == "" ||
                (mTbPhoneCh.Text=="" ||
                mTbPhoneRu.Text == "" ||
                mTbPhoneFr.Text == "" ||
                mTbPhoneGer.Text == "" ||
                mTbPhoneUS.Text == "" ||
                mTbPhoneUK.Text == "") )
            {
                MessageBox.Show("Required fields are missing");
            }
            else
            {
                string userInfo = "Name: " + textBoxLastName.Text + " " + textBoxFirstName.Text + " " + textBoxPatronim.Text + "\n";
                userInfo += "Address: " + comboBoxCountry.Text + ", " + comboBoxCIty.Text + "\n";
                if (mTbPhoneCh.Visible == true)
                {
                    userInfo += "Phone number: " + mTbPhoneCh.Text + "\n";
                }
                else if (mTbPhoneRu.Visible == true)
                {
                    userInfo += "Phone number: " + mTbPhoneRu.Text + "\n";
                }
                else if (mTbPhoneFr.Visible == true)
                {
                    userInfo += "Phone number: " + mTbPhoneFr.Text + "\n";
                }
                else if (mTbPhoneGer.Visible == true)
                {
                    userInfo += "Phone number: " + mTbPhoneGer.Text + "\n";
                }
                else if (mTbPhoneUS.Visible == true)
                {
                    userInfo += "Phone number: " + mTbPhoneUS.Text + "\n";
                }
                else if (mTbPhoneUK.Visible == true)
                {
                    userInfo += "Phone number: " + mTbPhoneUK.Text + "\n";
                }
                userInfo += "Date of Birth: " + dateTimeBirthdate.Value.ToString() + "\n";
                if (rbMale.Checked == true) userInfo += "Gender: Male\n";
                else userInfo += "Gender: Female\n";

                MessageBox.Show(userInfo, "Personal Information");

                try
                {
                    StreamWriter sw = new StreamWriter($"{textBoxLastName.Text}.txt");
                    sw.WriteLine(userInfo);
                    sw.Close();
                    MessageBox.Show($"Saved into: {textBoxLastName.Text}.txt", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while saving", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}

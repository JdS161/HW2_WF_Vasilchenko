using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void comboBoxCIty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int city = comboBoxCIty.SelectedIndex;

            //switch (city)
            //{
            //    case 0:
            //        comboBoxCountry.Items.Clear();
            //        comboBoxCountry.Items.AddRange(Rus_list);
            //        break;
            //    case 1:
            //        comboBoxCIty.Items.Clear();
            //        comboBoxCIty.Items.AddRange(Fr_list);
            //        break;
            //    case 2:
            //        comboBoxCIty.Items.Clear();
            //        comboBoxCIty.Items.AddRange(Ch_list);
            //        break;
            //    case 3:
            //        comboBoxCIty.Items.Clear();
            //        comboBoxCIty.Items.AddRange(Ger_list);
            //        break;
            //    case 4:
            //        comboBoxCIty.Items.Clear();
            //        comboBoxCIty.Items.AddRange(USA_list);
            //        break;
            //    case 5:
            //        comboBoxCIty.Items.Clear();
            //        comboBoxCIty.Items.AddRange(UK_list);
            //        break;
            //}
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int city = comboBoxCountry.SelectedIndex;

            switch (city)
            {
                case 0:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(Rus_list);
                    break;
                case 1:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(Fr_list);
                    break;
                case 2:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(Ch_list);
                    break;
                case 3:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(Ger_list);
                    break;
                case 4:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(USA_list);
                    break;
                case 5:
                    comboBoxCIty.Items.Clear();
                    comboBoxCIty.Items.AddRange(UK_list);
                    break;
            }
        }
    }
}

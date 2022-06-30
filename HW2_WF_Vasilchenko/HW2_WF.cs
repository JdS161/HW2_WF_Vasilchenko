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
    public partial class HW2_WF : Form
    {
        public HW2_WF()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            TimerForm timer = new TimerForm();
            timer.ShowDialog();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Coordinates coordinates = new Coordinates();
            coordinates.ShowDialog();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            PersInfo persInfo = new PersInfo();
            persInfo.ShowDialog();
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            Messages.CurriculumVitae();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Messages.CloseConfirmationDialog();
        }
    }


}

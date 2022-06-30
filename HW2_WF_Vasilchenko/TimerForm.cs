using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

namespace HW2_WF_Vasilchenko
{
    public partial class TimerForm : Form
    {
        int sec, cntr;
      
        public TimerForm()
        {
            InitializeComponent();
            buttonStop.Enabled = false;
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Timer finished", "Timer");
            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            sec = Convert.ToInt32(numericCounter.Value);
            cntr = Convert.ToInt32(numericCounter.Value);
            numericCounter.Enabled = false;
            timer1.Start();
            buttonStop.Enabled = true;
        }

    
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCountdown.Text = sec--.ToString();
            if(sec<0)
            {
                timer1.Stop();
                numericCounter.Enabled = true;
                MessageBox.Show("Timer finished", "Timer");
                buttonStop.Enabled = false;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (numericCounter.Value > 0)
                MessageBox.Show($"Timer had been stopped too early! \n\nTime left: \n{sec+1} seconds", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            buttonStop.Enabled = false;
            numericCounter.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

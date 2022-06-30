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
    public partial class Coordinates : Form
    {
        public Coordinates()
        {
            InitializeComponent();
        }


        private string ShowCoordinates(MouseEventArgs e)
        {
            return "Mouse coordinates: X = " + e.X.ToString() + "; Y = " + e.Y.ToString();
        }
        private string ShowPanelCoordinates(MouseEventArgs e)
        {
            return "Mouse coordinates: X = " + (e.X + panelInternal.Location.X).ToString() + "; Y = " + (e.Y + panelInternal.Location.Y).ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = ShowCoordinates(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string _msg = "";
            if (e.Button == MouseButtons.Left)
                _msg = $"Left button clicked!\n {ShowCoordinates(e)}";
            if (e.Button == MouseButtons.Right)
                _msg = $"Right button clicked!\n {ShowCoordinates(e)}";

            string _caption = "Mouse click";

            MessageBox.Show(_msg, _caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelInternal_MouseClick(object sender, MouseEventArgs e)
        {
            string msg = "";
            string cptn = "Coordinates task";

            if(e.Button == MouseButtons.Left)
            {
                if(e.Location.X == panelExternal.Location.X + panelInternal.Location.X || e.Location.Y == panelExternal.Location.Y + panelInternal.Location.Y)
                {
                    msg = "Mouse clicked on the border of blue panel";
                    MessageBox.Show(msg, cptn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    msg = "Mouse clicked inside blue panel";
                    MessageBox.Show(msg, cptn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if(e.Button == MouseButtons.Right)
            {
                cptn = "\n" + panelInternal.Size.ToString();
                MessageBox.Show(msg, cptn, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void panelInternal_MouseMove(object sender, MouseEventArgs e)
        {
            Text = ShowPanelCoordinates(e);
        }

        private void panelExternal_MouseClick(object sender, MouseEventArgs e)
        {
            string msg = "";
            string cptn = "Coordinates task";

            if (e.Button == MouseButtons.Left)
            {
                msg = "Mouse clicked outside blue panel";
                MessageBox.Show(msg, cptn, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                    
            if (e.Button == MouseButtons.Right)
            {
                cptn = "\n" + panelExternal.Size.ToString();
                MessageBox.Show(msg, cptn, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelExternal_MouseMove(object sender, MouseEventArgs e)
        {
            Text = ShowCoordinates(e);
        }
    }
}

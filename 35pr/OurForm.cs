using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35pr
{
    public partial class OurForm : Form
    {
        public OurForm()
        {
            InitializeComponent();
        }

        private void buttonOpenForm_Click(object sender, EventArgs e)
        {
            OurFormTwo ourFormTwo = new OurFormTwo();
            ourFormTwo.Show();
        }

        private void buttonOpenDialog_Click(object sender, EventArgs e)
        {
            OurFormTwo ourFormTwo = new OurFormTwo();
            ourFormTwo.ShowDialog();
        }

        private void OpenOurFormTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurFormTwo ourFormTwo = new OurFormTwo();
            ourFormTwo.MdiParent = this;
            ourFormTwo.Show();
        }

        private void OpenOurFormThreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurFormThree ourFormThree = new OurFormThree();
            ourFormThree.MdiParent = this;
            ourFormThree.Show();
        }

        private void buttonCloseALl_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void buttonOpenMDI_Click(object sender, EventArgs e)
        {
            OurFormThree ourFormThree = Application.OpenForms.OfType<OurFormThree>().FirstOrDefault();
            if (ourFormThree == null)
            {
                ourFormThree = new OurFormThree();
                ourFormThree.MdiParent = this;
                ourFormThree.Show();
            } else
            {
                ourFormThree.Activate();
            }
        }

    }
}

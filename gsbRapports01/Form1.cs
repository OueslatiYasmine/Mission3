using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports01
{
    public partial class Form1 : Form
    {

        private gsbrapports2016Entities mesdonneesEF;

        public Form1()
        {
            InitializeComponent();
            this.mesdonneesEF = new gsbrapports2016Entities();

        }

        private void faToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulter consulter = new frmConsulter(mesdonneesEF);
            consulter.ShowDialog();
        }

        private void gererToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGererMedocs gererMedocs = new frmGererMedocs(mesdonneesEF);
            gererMedocs.ShowDialog();
        }
    }
}

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
    public partial class frmConsulter : Form
    {
        private gsbrapports2016Entities mesDoneesEF;
        public frmConsulter(gsbrapports2016Entities mesDoneesEf)
        {
            InitializeComponent();
            this.mesDoneesEF = mesDoneesEf;

            this.bdgMedocs.DataSource = mesDoneesEF.medicaments.ToList();

            this.bdgSourceFM.DataSource = mesDoneesEF.familles.ToList();
            var familles = mesDoneesEF.familles;
            foreach(var famille in familles)
            {
                this.cmbFamillesM.Items.Add(famille.libelle);
            }
        }

        private void frmGerer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFamillesM_SelectedIndexChanged(object sender, EventArgs e)
        {
            var libfamilles = cmbFamillesM.Text;

            //requete link 

            var medicament = from m in mesDoneesEF.medicaments
                             join f in mesDoneesEF.familles on m.idFamille equals f.id
                             where f.libelle == libfamilles
                             select m;
            dataGridView1.DataSource = medicament.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

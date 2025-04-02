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
    public partial class frmGererMedocs : Form
    {
        private gsbrapports2016Entities mesDoneesEf;
        public frmGererMedocs(gsbrapports2016Entities mesDoneesEf)
        {
            InitializeComponent();
            this.mesDoneesEf = mesDoneesEf;
            this.medicamentBindingSource.DataSource = mesDoneesEf.medicaments.ToList();
            

            this.bdgFamilles.DataSource = mesDoneesEf.familles.ToList();

            var familles = mesDoneesEf.familles;
            foreach ( var famille in familles)
            {
                this.cmbSelectidF.Items.Add(famille.id);
            }
        }

        private medicament newMedocs()
        {
            medicament m = new medicament();
            m.id = txtIdMedocs.Text;
            m.composition = txtCompo.Text;
            m.nomCommercial = txtNomCom.Text;
            m.idFamille = cmbSelectidF.Text;
            m.contreIndications = txtContreInd.Text;
            m.effets = txtEffets.Text;

            return m;
        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtIdMedocs_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmGererMedocs_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.medicamentBindingSource.EndEdit();
            try
            {
                this.mesDoneesEf.medicaments.Add(newMedocs());
                this.mesDoneesEf.SaveChanges();
                MessageBox.Show("enregistrement réussi");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Petite Erreur de l'enregistrement {ex.Message}");
            }
        }

        private void txtIdFamilles_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSelectidF_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }
    }
}

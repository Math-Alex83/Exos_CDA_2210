using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Ph2_Validation
{
    public partial class FormControleur : Form
    {
        public FormControleur()
        {
            InitializeComponent();
            this.errorNomProvider.SetError(this.textBoxNom, "Champ Vide");
        }


        // NOM

        private void labNom_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        // DATE
        private void labDate_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        // MONTANT
        private void labMontant_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {

        }

        //CODE POSTAL
        private void labCP_Click(object sender, EventArgs e)
        {

        }
        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {

        }


        // VALIDER
        private void buttonValider_Click(object sender, EventArgs e)
        {

        }


        // EFFACER
        private void buttonEffacer_Click(object sender, EventArgs e)
        {

        }

    }
}

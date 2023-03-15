using Microsoft.VisualBasic;
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
        }


        // NOM

        private void labNom_Click(object sender, EventArgs e)
        {
            

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (!ClassControle.ControleNom(textBoxNom.Text))
            {
                errorNomProvider.SetError(textBoxNom, 
                    "Veuillez saisir votre nom en toutes lettres, jusqu'à 30 caractère Max.");

            }
            else
            {
                errorNomProvider.SetError(textBoxNom, "");

            }
        }

        // DATE
        private void labDate_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            if(!ClassControle.ControleDate(textBoxDate.Text))
            {
                errorDateProvider.SetError(textBoxDate,"Forma de la Date est incorrecte.");

            }
            else
            {
                errorDateProvider.SetError(textBoxDate,"");
            }
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
            if(ClassControle.ControleNom(textBoxNom.Text) 
                && ClassControle.ControleDate(textBoxDate.Text)
                && ClassControle.ControleMontant(textBoxMontant.Text))
            {
                MessageBox.Show(
                    "Nom : "+ textBoxNom.Text +"\r\n" 
                    + "Date : "+ textBoxDate.Text +"\r\n"
                    + "Montant : "+ textBoxMontant.Text + "\r\n"
                    + "Code Postal : "+ textBoxCP.Text);
            }
            else
            {
                errorNomProvider.SetError(this.textBoxNom, 
                    "Une érreure de saisie s'est produite");

            }

        }


        // EFFACER
        private void buttonEffacer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

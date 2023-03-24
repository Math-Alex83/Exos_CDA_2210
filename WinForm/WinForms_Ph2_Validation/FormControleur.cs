using Biblio_Controleur;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinForms_Ph2_Validation
{
    public partial class FormControleur : Form
    {
        public FormControleur()
        {
            InitializeComponent();
        }

        // NOM


        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (!ClassControle.ControleNom(textBoxNom.Text))
            {
                errorNomProvider.SetError(textBoxNom,
                    "Le format du Nom est incorrect, 30 caractère Maximum.");
            }
            else
            {
                errorNomProvider.SetError(textBoxNom, "");
            }
        }

        // DATE


        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            DateTime userDate;
            DateTime.TryParse(textBoxDate.Text, out userDate);

            if (!ClassControle.ControleDate(textBoxDate.Text))
            {
                if (userDate < DateTime.Today)
                {
                    errorDateProvider.SetError(textBoxDate, "Date invalide," + "\r\n" +
                    "veuillez ressaisir une date supperieur à celle du jour de saisie s'il vous plaît.");
                }
                else
                {
                    errorDateProvider.SetError(textBoxDate, "");
                }

            }

            else if (!ClassControle.ControleDate(textBoxDate.Text))
            {
                errorDateProvider.SetError(textBoxDate, "Format de date invalide," + "\r\n" +
                    "veuillez ressaisir la date au format jj/mm/aaaa ou jj/mm/aa s'il vous plaît.");
            }
            
            else
            {
                errorDateProvider.SetError(textBoxDate, "");
            }



        }

        // MONTANT


        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (!ClassControle.ControleMontant(textBoxMontant.Text))
            {
                errorMontantProvider.SetError(textBoxMontant,
                    "Le format du Montant saisi est incorrect.");
            }
            else
            {
                errorMontantProvider.SetError(textBoxMontant, "");
            }
        }

        //CODE POSTAL
        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {
            if (!ClassControle.ControleCP(textBoxCP.Text))
            {
                errorCPProvider.SetError(textBoxCP,
                    "Le format du Code Postasl saisi est incorrect.");
            }
            else
            {
                errorCPProvider.SetError(textBoxCP, "");
            }
        }


        // VALIDER
        /// <summary>
        /// Ouvre un MessageBox et affiche les info contenu en procédant à une deuxiemes vérif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (ClassControle.ControleNom(textBoxNom.Text)
                && ClassControle.ControleDate(textBoxDate.Text)
                && ClassControle.ControleMontant(textBoxMontant.Text)
                && ClassControle.ControleCP(textBoxCP.Text)
                )
            {
                MessageBox.Show(
                    "Nom : " + textBoxNom.Text + "\r\n"
                    + "Date : " + textBoxDate.Text + "\r\n"
                    + "Montant : " + textBoxMontant.Text + "\r\n"
                    + "Code Postal : " + textBoxCP.Text + "\r\n"
                    , "Validation effectuée");
            }
            else if (!ClassControle.ControleNom(textBoxNom.Text))
            {
                errorNomProvider.SetError(textBoxNom,
                                "Le Nom ne doit pas comporter de chiffres ni de carractère spéciaux");
            }

            DateTime userDate;
            if (!DateTime.TryParse(textBoxDate.Text, out userDate))
            {
                errorDateProvider.SetError(textBoxDate, "Format de date invalide," + "\r\n" +
                    "veuillez ressaisir la date au format jj/mm/aaaa ou jj/mm/aa s'il vous plaît.");
            }
            else if (DateTime.TryParse(textBoxDate.Text, out userDate))
            {
                DateTime.TryParse(textBoxDate.Text, out userDate);
                if (userDate < DateTime.Today)
                {
                    errorDateProvider.SetError(textBoxDate, "Date invalide," + "\r\n" +
                    "veuillez ressaisir une date supperieur à celle du jour de saisie s'il vous plaît.");
                }
            }
            else if (!ClassControle.ControleMontant(textBoxMontant.Text))
            {
                errorMontantProvider.SetError(textBoxMontant,
                                "Une erreur de saisie s'est produite");
            }
            else if (!ClassControle.ControleCP(textBoxCP.Text))
            {
                errorCPProvider.SetError(textBoxCP,
                                "Une erreur de saisie s'est produite");
            }
            /*
                       if (ClassControle.ControleNom(textBoxNom.Text)
                           && ClassControle.ControleDate(textBoxDate.Text)
                           && ClassControle.ControleMontant(textBoxMontant.Text)
                           && ClassControle.ControleCP(textBoxCP.Text)
                           )
                       {
                           MessageBox.Show(
                               "Nom : " + textBoxNom.Text + "\r\n"
                               + "Date : " + textBoxDate.Text + "\r\n"
                               + "Montant : " + textBoxMontant.Text + "\r\n"
                               + "Code Postal : " + textBoxCP.Text + "\r\n"
                               , "Validation effectuée");
                       }
                       else
                       {
                           errorNomProvider.SetError(textBoxNom,
                               "Une erreur de saisie s'est produite");
                           errorDateProvider.SetError(textBoxDate,
                               "Une erreur de saisie s'est produite");
                           errorMontantProvider.SetError(textBoxMontant,
                               "Une erreur de saisie s'est produite");
                           errorCPProvider.SetError(textBoxCP,
                               "Une erreur de saisie s'est produite");
                       }*/
        }

        // EFFACER OK 
        /// <summary>
        /// Efface le contenu des textBox et réinitialise les errorProvidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            this.textBoxNom.Clear();
            errorNomProvider.Clear();
            this.textBoxDate.Clear();
            errorDateProvider.Clear();
            this.textBoxMontant.Clear();
            errorMontantProvider.Clear();
            this.textBoxCP.Clear();
            errorCPProvider.Clear();
        }

        private void FormControleur_FormClosing(object sender, FormClosingEventArgs e)
        {
            // e.Cancel = true; // Annule la fermeture de la forme ( X = annulé )
        }
    }
}

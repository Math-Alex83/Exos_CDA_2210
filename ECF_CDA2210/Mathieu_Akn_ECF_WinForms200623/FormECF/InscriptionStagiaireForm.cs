namespace FormECF
{
    public partial class Form1 : Form
    {
        string formation;
        public Form1()
        {
            InitializeComponent();
            //buttonValider.Tag = radioButtonCDA.Text;
            formation = " ";
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (!ClassInscription.ControleNom(textBoxNom.Text))
            {
                errorProviderNom.SetError(textBoxNom,
                    "Le format du Nom est incorrect, 25 caractère Maximum.");
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "");
            }
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

            if (!ClassInscription.ControleNom(textBoxPrenom.Text))
            {
                errorProviderNom.SetError(textBoxPrenom,
                    "Le format du Nom est incorrect, 25 caractère Maximum.");
            }
            else
            {
                errorProviderNom.SetError(textBoxPrenom, "");
            }
        }

        private void textBoxDateDebut_TextChanged(object sender, EventArgs e)
        {
            DateTime userDate;
            DateTime.TryParse(textBoxDateDebut.Text, out userDate);

            if (!ClassInscription.ControleDateDebut(textBoxDateDebut.Text))
            {
                if (userDate < DateTime.Today)
                {
                    errorProviderDateD.SetError(textBoxDateDebut, "Date invalide," + "\r\n" +
                    "veuillez ressaisir une date supperieur à celle du jour de saisie s'il vous plaît.");
                }
                else
                {
                    errorProviderDateD.SetError(textBoxDateDebut, "");
                }

            }

            else if (!ClassInscription.ControleDateDebut(textBoxDateDebut.Text))
            {
                errorProviderDateD.SetError(textBoxDateDebut, "Format de date invalide," + "\r\n" +
                    "veuillez ressaisir la date au format jj/mm/aaaa ou jj/mm/aa s'il vous plaît.");
            }

            else
            {
                errorProviderDateD.SetError(textBoxDateDebut, "");
            }
        }

        private void textBoxDateFin_TextChanged(object sender, EventArgs e)
        {


        }




        public void radioButtonCDA_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButtonCDA.Checked)
            //{
            //     labelHide.Text= radioButtonCDA.Text;
            //}

            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;
                 formation = rb.Text;
            }










        }

        private void radioButtonDWWM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDWWM.Checked)
            {
                radioButtonDWWM.ToString();
            }
        }

        private void radioButtonABC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonABC.Checked)
            {
                radioButtonABC.ToString();
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                   "Nom : " + textBoxNom.Text + "\r\n"
                   + "Prénom : " + textBoxPrenom.Text + "\r\n"
                   + "Date : " + textBoxDateDebut.Text + "\r\n"
                   + "Date de fin : " + textBoxDateFin.Text + "\r\n"
                   + "Formation : " + formation+ "\r\n"
                   + "Stagiaire créé avec succes.");
        }

        private void labelHide_Click(object sender, EventArgs e)
        {
           
        }
    }
}
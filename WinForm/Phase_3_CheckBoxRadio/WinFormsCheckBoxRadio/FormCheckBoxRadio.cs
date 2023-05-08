using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCheckBoxRadio
{
    public partial class FormCheckBoxRadio : Form
    {
        
        public FormCheckBoxRadio()
        {
            InitializeComponent();
        }

        private void textBoxSaisieUtil_TextChanged(object sender, EventArgs e)
        {
            MiseAJourIHM();
        }

        private void MiseAJourIHM()
        {
            // copie le texte dans le label2 labelSaisieUtil
            labelSaisieUtil.Text = textBoxSaisieUtil.Text;

            if (checkBoxCasse.Checked)
            {
                if (radioButtonCasseMaj.Checked)
                {
                    labelSaisieUtil.Text = labelSaisieUtil.Text.ToUpper();
                } 
                else if (radioButtonCasseMinus.Checked)
                {
                    labelSaisieUtil.Text = labelSaisieUtil.Text.ToLower();
                }
            }
            // le grpBoxChoix est activé si il y a du texte saisie dans la textBox (si textBoxSaisieUtil n'est pas vide)
            groupBoxChoix.Enabled = (textBoxSaisieUtil.Text != "");
        }

        private void checkBoxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxFond.Visible = checkBoxCouleurFond.Checked;

            if (!checkBoxCouleurFond.Checked)
            {
                MiseAJourIHM();
                radioButtonFondRouge.Checked = false;
                radioButtonFondVert.Checked = false;
                radioButtonFondBleu.Checked = false;
            }
        }

        private void checkBoxCouleurCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCarac.Visible = checkBoxCouleurCaracteres.Checked;

            if (!checkBoxCouleurCaracteres.Checked)
            {
                MiseAJourIHM();
                radioButtonCaracRouge.Checked = false;
                radioButtonCaracBlanc.Checked = false;
                radioButtonCaracNoir.Checked = false;
            }
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCasse.Visible = checkBoxCasse.Checked;

            if (!checkBoxCasse.Checked)
            {
                MiseAJourIHM();
                radioButtonCasseMinus.Checked = false;
                radioButtonCasseMaj.Checked = false;
            }

        }

        private void radioButtonFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondRouge.Checked)
            {
                labelSaisieUtil.BackColor = Color.Red;
            }
            else
            {
                labelSaisieUtil.BackColor = Color.Transparent;
            }
            
        }

        private void radioButtonFondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondVert.Checked)
            {
                labelSaisieUtil.BackColor = Color.Green;
            }
            else
            {
                labelSaisieUtil.BackColor = Color.Transparent;
            }
        }

        private void radioButtonFondBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondBleu.Checked)
            {
                labelSaisieUtil.BackColor = Color.RoyalBlue;
            }
            else
            {
                labelSaisieUtil.BackColor = Color.Transparent;
            }
        }

        private void radioButtonCaracRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracRouge.Checked)
            {
                labelSaisieUtil.ForeColor = Color.Red;
            }
            else
            {
                labelSaisieUtil.ForeColor = Color.Black;
            }

        }

        private void radioButtonCaracBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracBlanc.Checked)
            {
                labelSaisieUtil.ForeColor = Color.White;
            }
            else
            {
                labelSaisieUtil.ForeColor = Color.Black;
            }

        }

        private void radioButtonCaracNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracNoir.Checked)
            {
                labelSaisieUtil.ForeColor = Color.Black;
            }
            else
            {
                labelSaisieUtil.ForeColor = Color.Black;
            }
        }

        private void radioButtonCasseMinus_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCasseMinus.Checked)
            {
                labelSaisieUtil.Text = textBoxSaisieUtil.Text.ToLower();
            }
            else
            {
                labelSaisieUtil.Text = textBoxSaisieUtil.Text;
            }
        }

        private void radioButtonCasseMaj_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCasseMaj.Checked)
            {
               
                labelSaisieUtil.Text = textBoxSaisieUtil.Text.ToUpper();
               
            }
            else
            {
                labelSaisieUtil.Text = textBoxSaisieUtil.Text;

            }

        }
    }
}

using Bibli_Addition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Addition
{
    

    public partial class Ladditionnator : Form
    {
   
        public Addition monAddition;

        public Ladditionnator()
        {
            InitializeComponent();
            monAddition = new Addition();

        }

        private void toucheCalculer_Click(object sender, EventArgs e)
        {
           // this.textBox1.Text = String.Format(" = " + calculer + " + ");
            this.textBox1.Text = String.Format(" = " + monAddition.Calculer() + " + ");

        }

        private void toucheVider_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Clear(); // vide la texteBox
            //monAddition.Vider(); // vide les valeur contenues dans la liste
            monAddition = new Addition();

        }

        private void boutons_ensemble(object sender, EventArgs e)
        {
            
            /* Button boutons_ensemble = (Button)sender;
             boutons_ensemble = sender as Button;*/
            
            int valeur = 0;

            if(sender is Button boutons_ensemble)
            {
                this.textBox1.Text += boutons_ensemble.Text + " + ";
                valeur = Convert.ToInt32(boutons_ensemble.Text);
   
                monAddition.Add(valeur); // ajoute la valeur saisie dans la liste
            }
            else
            {
                MessageBox.Show("Erreur de calcul", "ERREUR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }










        private void touche0_Click_1(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 0 + \r\n";
                        somme += 0;
            */
        }

        private void touche1_Click(object sender, EventArgs e)
        {
            /*
            Button touche1 = (Button)sender;
            textBox1.Text += touche1.Text+"+";
            */
            /*            this.textBox1.Text += " 1 + \r\n";
                        somme += 1;
            */
        }

        private void touche2_Click(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 2 + \r\n";
                        somme += 2;
            */
        }

        private void touche3_Click(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 3 + \r\n";
                        somme += 3;
            */
        }

        private void touche4_Click(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 4 + \r\n";
                        somme += 4;
            */
        }

        private void touche5_Click(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 5 + \r\n";
                        somme += 5;
            */
        }

        private void touche6_Click(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 6 + \r\n";
                        somme += 6;
            */
        }


        private void touche7_Click(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 7 + \r\n";
                        somme += 7;
            */
        }


        private void touche8_Click(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 8 + \r\n";
                        somme += 8;
            */
        }

        private void touche9_Click(object sender, EventArgs e)
        {
            /*            this.textBox1.Text += " 9 + \r\n";
                        somme += 9;
            */
        }

        private void Ladditionnator_Load(object sender, EventArgs e)
        {

        }
    }
}

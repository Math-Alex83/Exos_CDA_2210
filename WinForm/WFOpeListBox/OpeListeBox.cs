using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WFOpeListBox
{
    public partial class OpeListeBox : Form
    {
        //List<string> nameList = new List<string> { };
        public OpeListeBox()
        {
            InitializeComponent();
        }

        private void textBoxNewElement_TextChanged(object sender, EventArgs e)
        {
           //if(Regex.Match(textBoxNewElement.Text, @"^(?=^[A-z/é/ä/â/é/è/ë/ê/ç/ï/ö/ô]+(?:-[A-z]+)*$).{1,30}$").Success)
           // {

           // }
        }

        private void buttonAddLst_Click(object sender, EventArgs e)
        {
            if (Regex.Match(textBoxNewElement.Text, @"^(?=^[A-Z/é/ä/â/é/è/ë/ê/ç/ï/ö/ô][a-z]+(?:-[A-z]+)*$).{1,30}$").Success)
            {
                if (!listBox.Items.Contains(textBoxNewElement.Text))
                {
                    listBox.Items.Add(textBoxNewElement.Text);
                    textBoxNewElement.Text = "";
                }
                else
                {
                    MessageBox.Show(textBoxNewElement.Text +
                   " Ce nom existe déjà, " +
                   "veuillez saisir un nom qui n'existe pas dans la liste.");
                    textBoxNewElement.Text = "";
                }
            }
            else
            {
                MessageBox.Show(textBoxNewElement.Text + 
                    " Ce nom ne respecte pas le format recommandé, veuillez le saisir dans un format valide.");
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v = (string)listBox.SelectedItem;    
        }

        private void textBoxIndexElement_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
        }

        private void buttonClearLst_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void textBoxItemsCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSelectedIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

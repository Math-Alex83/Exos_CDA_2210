using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCarOwners2.Models;

namespace WinFormsCarOwners2
{
    public partial class FormCarsOwner : Form
    {
        private CarOwners2Context dbContext;

        public FormCarsOwner()
        {
            InitializeComponent();
            dbContext = new CarOwners2Context();
            dbContext.Cars.Load();
            dataGridViewCar.DataSource = dbContext.Cars.Local.ToBindingList();
        }

        private void dataGridViewCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AddCar_Click(object sender, EventArgs e)
        {
            if (textBoxCarName.Text != "" && textBoxCarRegistration.Text != "")
            {
                Car c = new Car();
                c.CarName = this.textBoxCarName.Text;
                c.CarRegistration = this.textBoxCarRegistration.Text;
                dbContext.Cars.Add(c);
                dbContext.SaveChanges();
                this.dataGridViewCar.Refresh();
            }
            else
            {
                MessageBox.Show("Erreure fratale !");
            }
        }

        private void DeleteCar_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(textBoxCarName.Text,out id);
            if (idOk)
            {
                Car? cASupprimer = dbContext.Cars.Find(id); // Car? veut dire nullable.
                if (cASupprimer != null)
                {
                    dbContext.Cars.Remove(cASupprimer);
                    dbContext.SaveChanges();
                }
            }
        }
        private void AddOwner_Click(object sender, EventArgs e)
        {

        }

        private void DeleteOwner_Click(object sender, EventArgs e)
        {

        }



        private void EditTable_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(textBoxCarName.Text, out id);
            string newName = textBoxEdite.Text;
            if (idOk)
            {
                Car? cAModifier = dbContext.Cars.Find(id);
                if (cAModifier != null)
                {
                    if (textBoxEdite.Text != "")
                    {
                        cAModifier.CarName = textBoxEdite.Text;
                        cAModifier.CarRegistration = textBoxEditRegistration.Text;
                        dbContext.Cars.Update(cAModifier);
                        dbContext.SaveChanges();
                        this.dataGridViewCar.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Prout");
                    }
                }
            }
            else
            {
                MessageBox.Show("Echec proutification");
            }
        }

        private void textBoxCarName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEdite_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCarRegistration_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEditRegistration_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

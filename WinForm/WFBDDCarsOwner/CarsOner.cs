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
using WFBDDCarsOwner.Models;

namespace WFBDDCarsOwner
{
    public partial class CarsOner : Form
    {
        private CarsOwnersContext bddContext;

        public CarsOner()
        {
            InitializeComponent();
            // Créer le lien vers la source
            bddContext = new CarsOwnersContext();
            // chargement de la table Cars
            bddContext.Cars.Load<Car>();

            // Création d'un Binding entre la source des données Cars et le DataGridViewCar
            // [ATTENTION -->( DataGridViewCar = Nom de la forme "DataDrid" )]
            dataGridViewCar.DataSource = bddContext.Cars.Local.ToBindingList();

        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            // Ajouter une new voiture
            Car c = new Car();
            c.CarId = 32;
            c.CarName = "titoi";
            c.CarRegistration = "";
            bddContext.Cars.Add(c);
            bddContext.SaveChanges();
            this.dataGridViewCar.Refresh();

        }

        private void DeleteCar_Click(object sender, EventArgs e)
        {

        }

        private void AddOwner_Click(object sender, EventArgs e)
        {

        }

        private void DeleteOwner_Click(object sender, EventArgs e)
        {

        }


        private void EditTable_Click(object sender, EventArgs e)
        {

        }
    }
}

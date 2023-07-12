using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibraryFigures;

namespace WindowsFormsPaint
{
    public partial class FormPaint : Form
    {
        Point lastlastPointDown;
        Point lastPointDown;
        Point lastlastPointUp;
        Point lastPointUp;
        Figures figuresCourantes;

        public FormPaint()
        {
            InitializeComponent();
            figuresCourantes = new Figures();
        }

        private void panelDessin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                Point pt = this.PointToScreen(e.Location);
                contextMenuStripChoix.Show(pt);
            }
        }

        private void contextMenuStripChoix_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("addRectangle"))
            {
                // le rectangle doit être construit ici
            }
            else if (e.ClickedItem.Text.Equals("addCercle"))
            {
                // le cercle doit être construit ici
            }
        }

        private void panelDessin_Paint(object sender, PaintEventArgs e)
        {
            //les figures doivent être dessinées ici: Exemple
            VisiteurFigurePourWinform v = new VisiteurFigurePourWinform(e.Graphics);
            v.Visit(new ClassLibraryFigures.Cercle());

        }

        private void panelDessin_MouseDown(object sender, MouseEventArgs e)
        {
            lastlastPointDown = lastPointDown; // a améliorer
            lastPointDown=e.Location;

        }

        private void panelDessin_MouseUp(object sender, MouseEventArgs e)
        {
            lastlastPointUp = lastPointUp; // a améliorer
            lastPointUp = e.Location;
        }


        private void grouper_Click(object sender, EventArgs e)
        {
            Figures figuresAGrouper = new Figures();
            System.Drawing.Rectangle zoneSelectionne = new System.Drawing.Rectangle(lastlastPointDown.X, lastlastPointDown.Y, lastlastPointUp.X, lastlastPointUp.Y);
            foreach (Figure f in figuresCourantes.Listes)
            {
                if (zoneSelectionne.Contains(new Point(f.X, f.Y)))
                {
                    figuresAGrouper.Add(f);
                }
            }
        }

        private void dissocier_Click(object sender, EventArgs e)
        {
            //afaire
        }




    }
}

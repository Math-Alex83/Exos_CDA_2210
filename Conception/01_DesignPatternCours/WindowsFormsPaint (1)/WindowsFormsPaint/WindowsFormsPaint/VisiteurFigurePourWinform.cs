using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ClassLibraryFigures;

namespace WindowsFormsPaint
{
    class VisiteurFigurePourWinform : IVisiteur<bool>
    {
        Graphics graphics;

        public VisiteurFigurePourWinform(Graphics _graphics)
        {
            graphics = _graphics;
        }


        public bool Visit(Cercle _c)
        {

            Pen p = new Pen(Color.Black);
            graphics.DrawEllipse(p, new System.Drawing.Rectangle(new Point(100, 400), new Size(100, 100)));
            return true;
        
        }

        public bool Visit(ClassLibraryFigures.Rectangle _r)
        {

            Pen p = new Pen(Color.Black);
            graphics.DrawRectangle(p, new System.Drawing.Rectangle(new Point(10, 40), new Size(90, 50)));
            return true;
        }


        public bool Visit(Figures _r)
        {
            foreach (Figure f in _r.Listes)
            {
                //...
            }
            return true;
        }
    }
}

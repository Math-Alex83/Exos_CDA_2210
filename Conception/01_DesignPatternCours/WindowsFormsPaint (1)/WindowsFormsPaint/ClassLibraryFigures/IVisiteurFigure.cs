using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryFigures
{
    public interface IVisiteur<T>
    {
        T Visit(Cercle _c);
        T Visit(Rectangle _r);
        //etc..
        T Visit(Figures _r);
    }
}

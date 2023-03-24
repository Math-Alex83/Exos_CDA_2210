using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblio_Controleur
{
    public class ClassControle
    {
        public static bool ControleNom(string _nom)
        {
            return Regex.Match(_nom, @"^(?=^[A-z/é/ä/â/é/è/ë/ê/ç/ï/ö/ô]+(?:-[A-z]+)*$).{1,30}$").Success;
        }

        public static bool ControleDate(string date)
        {
            DateTime userDate;

            if (DateTime.TryParse(date, out userDate))
            {
                    if (userDate > DateTime.Today)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            else
            {
                return false;
            }
        }
        public static bool ControleMontant(string montant)
        {
            
            return Regex.Match(montant, @"^[0-9]{1,6}(?:[.,][0-9]{2})?$").Success; 
            // ? <-- seul est = à {0,1}
            // ?: <-- Groupe de non capture (Regex101 ne sépare pas les deux parties, il test toute la Regex.

        }

        public static bool ControleCP(string cp)
        {
            return Regex.Match(cp, @"^[0-9]{5}$").Success;
        }

    }
}

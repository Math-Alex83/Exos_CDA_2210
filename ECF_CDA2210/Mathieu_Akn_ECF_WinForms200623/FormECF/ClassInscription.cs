using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormECF
{
    internal class ClassInscription
    {
        public static bool ControleNom(string _nom)
        {
            return Regex.Match(_nom, @"^(?=^[A-z/é/ä/â/é/è/ë/ê/ç/ï/ö/ô]+(?:-[A-z]+)*$).{1,25}$").Success;
        }

        public static bool ControleDateDebut(string date)
        {
            DateTime userDateDebut;
            string format = "dd/mm/yyyy";

            if (DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out userDateDebut))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ControleDateFin(string date) // Controle a faire pour veriffier si DateFin n'est pas inférieur ou egal à DateDebut.
        {
            DateTime userDateFin;
            string format = "dd/mm/yyyy";

            if (DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out userDateFin))
            {
                    return true;

            }
            else
            {
                return false;
            }
        }


    }
}

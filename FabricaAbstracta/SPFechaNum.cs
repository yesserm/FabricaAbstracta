using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    class SPFechaNum : FechaNum
    {
        public override string PresentarFN()
        {
            DateTime hoy = new DateTime();
            hoy = DateTime.Now;
            return hoy.ToString("d", CultureInfo.CreateSpecificCulture("es-MX"));
        }
    }
}

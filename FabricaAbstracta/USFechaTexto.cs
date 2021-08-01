using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    class USFechaTexto : FechaTexto
    {
        public override string PresentarFT()
        {
            DateTime hoy = new DateTime();
            hoy = DateTime.Now;
            return hoy.ToString("D", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}

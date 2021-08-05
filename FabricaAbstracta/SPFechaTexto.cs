using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    class SPFechaTexto : FechaTexto
    {
        public SPFechaTexto(int a, int m, int d)
        {
            this.Year = a;
            this.Mes = m;
            this.Dia = d;
        }
        public override string PresentarFT()
        {
            DateTime hoy = new DateTime(this.Year,this.Mes, this.Dia);
            //hoy = DateTime.Now;
            return hoy.ToString("D", CultureInfo.CreateSpecificCulture("es-MX"));
        }
    }
}

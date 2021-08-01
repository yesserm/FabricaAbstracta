using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    public abstract class FechaNum
    {
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Year { get; set; }
        public abstract String PresentarFN();

    }
}

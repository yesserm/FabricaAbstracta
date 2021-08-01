using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    class SPFechaFactory : IFechaFactory
    {
        public FechaNum CrearFechaNum()
        {
            return new SPFechaNum();
        }

        public FechaTexto CrearFechaTexto()
        {
            return new SPFechaTexto();
        }
    }
}

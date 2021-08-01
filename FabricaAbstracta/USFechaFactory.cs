using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    class USFechaFactory : IFechaFactory
    {
        public FechaNum CrearFechaNum()
        {
            return new USFechaNum();
        }

        public FechaTexto CrearFechaTexto()
        {
            return new USFechaTexto();
        }
    }
}

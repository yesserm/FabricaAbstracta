using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    interface IFechaFactory
    {
        FechaNum CrearFechaNum();
        FechaTexto CrearFechaTexto(int a, int m, int d);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta
{
    public abstract class FechaTexto
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Year { get; set; }
        public abstract String PresentarFT();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Dominguez
{
    public class Empleado : Persona
    {
        public int Legajo { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public int Sueldo { get; set; }

    }
    
}

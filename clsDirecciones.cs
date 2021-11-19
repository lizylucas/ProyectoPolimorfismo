using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPolimorfismo
{
    public class clsDirecciones
    {
        public clsDirecciones()
        {
            Calle = string.Empty;
            NumeroExterior = string.Empty;
            Parroquia = string.Empty;
            Ciudad = string.Empty;
            CP = string.Empty;
        }
        public string  Calle  { get; set; }
        public string  NumeroExterior { get; set; }
        public string  NumeroInterior { get; set; }
        public string Parroquia { get; set; }
        public string Ciudad { get; set; }
        public string  CP { get; set; }

    }
}
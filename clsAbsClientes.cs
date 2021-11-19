using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPolimorfismo
{
    public abstract  class clsAbsClientes
    {
        public abstract int Id { get; set; }

        public abstract string Nombre { get; set; }

        public abstract string Clave { get; set; }

        public abstract string RUC { get; set; }

        public abstract int tipoRegimen { get; set; }

        public abstract string NombreContacto { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPolimorfismo
{
    public class ClsClientesBase : clsAbsClientes
    {
        public ClsClientesBase()
        {
            Id = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
            RUC = string.Empty;
            tipoRegimen = 0;
            NombreContacto = string.Empty;
        }

        public ClsClientesBase(int pId, string pNombre, string pClave,
            string pRUC, int pTipoRegimen, string pNombreCompleto)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RUC = pRUC;
            tipoRegimen = pTipoRegimen;
            NombreContacto = pNombreCompleto;

        }
        public override int Id { get; set; }

        public override string Nombre { get; set; }

        public override string  Clave { get; set; }

        public override string RUC { get; set; }

        public override int tipoRegimen { get; set; }

        public override string NombreContacto { get; set; }

    }
}

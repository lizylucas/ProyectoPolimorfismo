using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPolimorfismo
{
    public class clsClientesConContacto : ClsClientesBase
    {
        public clsClientesConContacto()
        {
            _Direccion = new clsDirecciones();
        }

        public clsClientesConContacto(int pId, string pNombre, string pClave,
                                        string pRUC, int pTipoRegimen,
                                        string pNombreContacto, string pTelefono1,
                                        string pTelefono2, string pEmail,
                                        string pCalle, string pNumeroExterior,
                                        string pNumeroInterior, string pParroquia,
                                        string pCiudad, string pCP)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RUC = pRUC;
            tipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Email = pEmail;
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroInterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Parroquia = pParroquia;
            Direccion.Ciudad = pCiudad;
            Direccion.CP = pCP;




        }
                  
       
    

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Email { get; set; }
        public clsDirecciones Direccion { get => _Direccion; set => _Direccion = value; }

        private clsDirecciones _Direccion;

    }
}

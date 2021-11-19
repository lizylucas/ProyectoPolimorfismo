using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPolimorfismo
{
    public class clsImpresion
    {
        public void ImprimeCliente(clsAbsClientes cliente)
        {
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.tipoRegimen);
            Console.WriteLine(cliente.RUC);
            Console.ReadKey();

        }

    }
}

using System;

namespace ProyectoPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           clsClientesConContacto cliente = new clsClientesConContacto(0,"Drake Buenaventura",
                                                               "001",
                                                              "0111300224567",
                                                             1,"Drake Buenaventura",
                                                             "0995597582", " ," ,"rony@gmail.com",
                                                             "Calle 108 av 109","119","",
                                                             "Parroquia tarqui",
                                                             "Manta","29096");
            clsImpresion Impresion;
            Impresion = new clsImpresion();

            Impresion.ImprimeCliente(cliente);

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso070224.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuPrincipalYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Alta actividad");
            Console.WriteLine("2. Mostrar actividad");
            Console.WriteLine("3. Eliminar actividad");
            Console.WriteLine("Escriba la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}

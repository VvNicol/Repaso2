namespace Repaso070224.Controladores
{
    using Servicios;
    using Dtos;
    class Program
    {

        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            List<ActividadDto> listaActividades = new List<ActividadDto>();

            int opcionPrincipal;
            bool cerrarPrincipal = false;

            do
            {
                Console.WriteLine("MENÚ INICIAL");
                opcionPrincipal = mi.mostrarMenuPrincipalYSeleccion();
                switch (opcionPrincipal)
                {

                    case 0:
                        Console.WriteLine("Se cierra la aplicación");
                        cerrarPrincipal = true;
                        break;
                    case 1:
                        Console.WriteLine("ALTA ACTIVIDAD");
                        oi.darAltaActividad(listaActividades);
                        break;
                    case 2:
                        Console.WriteLine("MOSTRAR ACTIVIDAD");
                        oi.mostrarActividad(listaActividades);
                        break;
                    case 3:
                        Console.WriteLine("ELIMINAR ACTIVIDAD");
                        oi.eliminarActividad(listaActividades);
                        break;
                    default:
                        Console.WriteLine("No se ha elegido una opción aceptable");
                        break;
                }

            } while (!cerrarPrincipal);
        }

    }
}

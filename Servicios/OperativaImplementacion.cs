using Repaso070224.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso070224.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaActividad(List<ActividadDto> listaActividades)
        {
            Console.WriteLine("Indica la actividad: ");
            string nombreA = Console.ReadLine();
            Console.WriteLine("Fecha de inicio en formato dd/MM/yyyy HH:mm:ss");
            DateTime fchInicioA = Convert.ToDateTime(Console.ReadLine());

            ActividadDto actividad = new ActividadDto(nombreA, fchInicioA);
            listaActividades.Add(actividad);

        }

        public void eliminarActividad(List<ActividadDto> listaActividades)
        {

            ActividadDto auxiliarActividad = new ActividadDto();
            bool existe = false;

            foreach (ActividadDto actividad in listaActividades)
            {
                Console.WriteLine(actividad.ToString());
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Nombre de la actividad: ");
            string nombreA = Console.ReadLine();

            foreach (ActividadDto actividad in listaActividades)
            {
                if (nombreA.Equals(actividad.NombreActividad))
                {
                    auxiliarActividad = actividad;
                    existe = true;
                    //listaActividades.Remove(auxiliarActividad);
                    break;
                }
            }
            if (existe)
            {
                listaActividades.Remove(auxiliarActividad);
            }
            else
            {
                Console.WriteLine("La actividad buscada no existe.");
            }
        }

        public void mostrarActividad(List<ActividadDto> listaActividades)
        {
            Console.WriteLine("Nombre de la actividad: ");
            string nombreA = Console.ReadLine();

            foreach (ActividadDto actividad in listaActividades)
            {
                if (nombreA.Equals(actividad.NombreActividad))
                {
                    Console.WriteLine(actividad.ToString());
                }
            }

        }
    }
}

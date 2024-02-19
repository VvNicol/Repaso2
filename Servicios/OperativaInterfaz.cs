using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repaso070224.Dtos;

namespace Repaso070224.Servicios
{
    internal interface OperativaInterfaz
    {

        public void darAltaActividad(List<ActividadDto> listaActividades);

        public void mostrarActividad(List<ActividadDto> listaActividades);

        public void eliminarActividad(List<ActividadDto> listaActividades);

    }
}

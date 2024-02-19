using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso070224.Dtos
{
    internal class ActividadDto
    {

        string nombreActividad = "aaaaa";
        DateTime fchInicioActividad = new DateTime(9999,12,31,23,59,59);
        DateTime fchFinActividad = DateTime.Now;
        TimeSpan minutosDuracion;

        public ActividadDto() { }

        public ActividadDto(string nombreActividad, DateTime fchInicioActividad)
        {
            this.nombreActividad = nombreActividad;
            this.fchInicioActividad = fchInicioActividad;
            this.minutosDuracion = fchFinActividad - fchInicioActividad;
        }

        public string NombreActividad { get => nombreActividad; set => nombreActividad = value; }
        public DateTime FchInicioActividad { get => fchInicioActividad; set => fchInicioActividad = value; }
        public DateTime FchFinActividad { get => fchFinActividad; set => fchFinActividad = value; }
        public TimeSpan MinutosDuracion { get => minutosDuracion; set => minutosDuracion = value; }

        override
        public string ToString()
        {            
            return this.NombreActividad + " - " + this.MinutosDuracion.TotalMinutes;
        }
    
    }
}

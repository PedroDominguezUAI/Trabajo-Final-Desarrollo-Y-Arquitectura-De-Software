using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class EventoEntity
    {
        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaEvento { get; set; } 
        public EstadioEntity Estadio { get; set; }

        public override string ToString()
        {
            return this.NombreEvento;
        }
    }
}

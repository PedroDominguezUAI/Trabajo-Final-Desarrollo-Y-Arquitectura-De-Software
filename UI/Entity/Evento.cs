using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaEvento { get; set; } 
        public Estadio Estadio { get; set; }

         
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class EntradaEntity
    {
        public int IdEntrada { get; set; }
        public string Sector { get; set; }
        public string? Asiento { get; set; }
        public decimal Precio { get; set; }
        public DateTime? FechaAsignacion { get; set; } 
        public EventoEntity Evento { get; set; }

        
        public UsuarioEntity? Usuario { get; set; }
    }
}

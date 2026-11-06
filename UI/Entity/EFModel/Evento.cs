using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class Evento
{
    public int IdEvento { get; set; }

    public string NombreEvento { get; set; } = null!;

    public DateTime FechaEvento { get; set; }

    public int IdEstadio { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual Estadio IdEstadioNavigation { get; set; } = null!;
}

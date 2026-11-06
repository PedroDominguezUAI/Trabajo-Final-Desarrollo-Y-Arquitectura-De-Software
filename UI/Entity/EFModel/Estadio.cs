using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class Estadio
{
    public int IdEstadio { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int Capacidad { get; set; }

    public virtual ICollection<Evento> Evento { get; set; } = new List<Evento>();
}

using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class Entrada
{
    public int IdEntrada { get; set; }

    public int IdEvento { get; set; }

    public int? IdUsuario { get; set; }

    public string Sector { get; set; } = null!;

    public string? Asiento { get; set; }

    public decimal Precio { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public virtual Evento IdEventoNavigation { get; set; } = null!;

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}

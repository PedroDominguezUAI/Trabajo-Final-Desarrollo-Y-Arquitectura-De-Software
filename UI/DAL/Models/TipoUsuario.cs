using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TipoUsuario
{
    public int IdTipo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Usuario> Usuario { get; set; } = new List<Usuario>();
}

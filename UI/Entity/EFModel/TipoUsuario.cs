using System;
using System.Collections.Generic;

namespace Entity.EFModel;

public partial class TipoUsuario
{
    public int IdTipo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Usuario> Usuario { get; set; } = new List<Usuario>();
}

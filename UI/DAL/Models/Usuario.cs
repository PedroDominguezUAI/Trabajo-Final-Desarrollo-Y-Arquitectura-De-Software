using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int IdTipo { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual TipoUsuario IdTipoNavigation { get; set; } = null!;
}

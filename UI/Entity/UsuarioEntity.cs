using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class UsuarioEntity
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public TipoUsuarioEntity TipoUsuario { get; set; }

    }
}

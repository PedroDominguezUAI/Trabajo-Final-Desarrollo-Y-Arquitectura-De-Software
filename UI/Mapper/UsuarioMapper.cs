using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class UsuarioMapper
    {
        // De Entity Framework (BD) a Dominio
        public static Entity.UsuarioEntity Map(Entity.EFModel.Usuario usuarioEF)
        {
            if (usuarioEF == null) return null!;

            return new Entity.UsuarioEntity
            {
                IdUsuario = usuarioEF.IdUsuario,
                NombreUsuario = usuarioEF.NombreUsuario,
                Password = usuarioEF.Password,
                Nombre = usuarioEF.Nombre,
                Apellido = usuarioEF.Apellido,
                Dni = usuarioEF.Dni,
                Email = usuarioEF.Email,
                 
                TipoUsuario = usuarioEF.IdTipoNavigation != null
                    ? TipoUsuarioMapper.Map(usuarioEF.IdTipoNavigation)
                    : null!
            };
        }
 
        public static Entity.EFModel.Usuario Map(Entity.UsuarioEntity usuarioEntity)
        {
            if (usuarioEntity == null) return null!;

            return new Entity.EFModel.Usuario
            {
                IdUsuario = usuarioEntity.IdUsuario,
                NombreUsuario = usuarioEntity.NombreUsuario,
                Password = usuarioEntity.Password,
                Nombre = usuarioEntity.Nombre,
                Apellido = usuarioEntity.Apellido,
                Dni = usuarioEntity.Dni,
                Email = usuarioEntity.Email,
                IdTipo = usuarioEntity.TipoUsuario != null ? usuarioEntity.TipoUsuario.IdTipo : 0,
                IdTipoNavigation = usuarioEntity.TipoUsuario != null
                    ? TipoUsuarioMapper.Map(usuarioEntity.TipoUsuario)
                    : null!
            };
        }
    }
}

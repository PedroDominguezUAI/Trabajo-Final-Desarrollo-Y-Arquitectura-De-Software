using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;

namespace Mapper
{
    public static class UsuarioMapper
    {
        // 1. De Entity Framework (BD) a Dominio (Un solo objeto)
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

        // 2. De Dominio a Entity Framework (BD) (Un solo objeto)
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

                IdTipo = usuarioEntity.TipoUsuario != null ? usuarioEntity.TipoUsuario.IdTipo : 0
                
            };
        }

    
        public static List<Entity.UsuarioEntity> Map(List<Entity.EFModel.Usuario> listaUsuariosEF)
        {
            if (listaUsuariosEF == null) return new List<Entity.UsuarioEntity>();

            return listaUsuariosEF.Select(u => Map(u)).ToList();
        }

       
        public static List<Entity.EFModel.Usuario> Map(List<Entity.UsuarioEntity> listaUsuariosEntity)
        {
            if (listaUsuariosEntity == null) return new List<Entity.EFModel.Usuario>();

            return listaUsuariosEntity.Select(u => Map(u)).ToList();
        }
    }
}
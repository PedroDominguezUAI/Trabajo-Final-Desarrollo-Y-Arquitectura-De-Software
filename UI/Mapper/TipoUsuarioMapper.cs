using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class TipoUsuarioMapper
    {
         
        public static Entity.TipoUsuarioEntity Map(Entity.EFModel.TipoUsuario tipoEF)
        {
            if (tipoEF == null) return null!;

            return new Entity.TipoUsuarioEntity
            {
                IdTipo = tipoEF.IdTipo,
                Descripcion = tipoEF.Descripcion
            };
        }

         
        public static Entity.EFModel.TipoUsuario Map(Entity.TipoUsuarioEntity tipoEntity)
        {
            if (tipoEntity == null) return null!;

            return new Entity.EFModel.TipoUsuario
            {
                IdTipo = tipoEntity.IdTipo,
                Descripcion = tipoEntity.Descripcion
            };
        }
    }
}

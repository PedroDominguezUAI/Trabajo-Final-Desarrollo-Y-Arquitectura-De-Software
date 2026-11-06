using System;
using System.Collections.Generic;
using System.Text;

namespace Mapper
{
    public static class EstadioMapper
    {
      
        public static Entity.EstadioEntity Map(Entity.EFModel.Estadio estadioEF)
        {
            if (estadioEF == null) return null!;

            return new Entity.EstadioEntity
            {
                IdEstadio = estadioEF.IdEstadio,
                Nombre = estadioEF.Nombre,
                Direccion = estadioEF.Direccion,
                Capacidad = estadioEF.Capacidad
            };
        }
 
        public static Entity.EFModel.Estadio Map(Entity.EstadioEntity estadioEntity)
        {
            if (estadioEntity == null) return null!;

            return new Entity.EFModel.Estadio
            {
                IdEstadio = estadioEntity.IdEstadio,
                Nombre = estadioEntity.Nombre,
                Direccion = estadioEntity.Direccion,
                Capacidad = estadioEntity.Capacidad
            };
        }
    }
}

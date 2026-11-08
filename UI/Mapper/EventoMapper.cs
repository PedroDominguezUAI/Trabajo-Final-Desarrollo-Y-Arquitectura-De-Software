using System;
using System.Collections.Generic;
using System.Linq; 

namespace Mapper
{
    public static class EventoMapper
    {
        
        public static Entity.EventoEntity Map(Entity.EFModel.Evento eventoEF)
        {
            if (eventoEF == null) return null!;

            return new Entity.EventoEntity
            {
                IdEvento = eventoEF.IdEvento,
                NombreEvento = eventoEF.NombreEvento,
                FechaEvento = eventoEF.FechaEvento,
                Estadio = eventoEF.IdEstadioNavigation != null
                    ? EstadioMapper.Map(eventoEF.IdEstadioNavigation)
                    : null!
            };
        }

        
        public static List<Entity.EventoEntity> Map(List<Entity.EFModel.Evento> listaEF)
        {
            if (listaEF == null) return new List<Entity.EventoEntity>();

            return listaEF.Select(Map).ToList();
        }

        
        public static Entity.EFModel.Evento Map(Entity.EventoEntity eventoEntity)
        {
            if (eventoEntity == null) return null!;

            return new Entity.EFModel.Evento
            {
                IdEvento = eventoEntity.IdEvento,
                NombreEvento = eventoEntity.NombreEvento,
                FechaEvento = eventoEntity.FechaEvento,
                
                IdEstadio = eventoEntity.Estadio != null ? eventoEntity.Estadio.IdEstadio : 0
            };
        }
    }
}
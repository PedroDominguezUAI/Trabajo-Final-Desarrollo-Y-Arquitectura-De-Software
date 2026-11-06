using System;
using System.Collections.Generic;
using System.Text;

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

        
        public static Entity.EFModel.Evento Map(Entity.EventoEntity eventoEntity)
        {
            if (eventoEntity == null) return null!;

            return new Entity.EFModel.Evento
            {
                IdEvento = eventoEntity.IdEvento,
                NombreEvento = eventoEntity.NombreEvento,
                FechaEvento = eventoEntity.FechaEvento,
                IdEstadio = eventoEntity.Estadio != null ? eventoEntity.Estadio.IdEstadio : 0,
                IdEstadioNavigation = eventoEntity.Estadio != null
                    ? EstadioMapper.Map(eventoEntity.Estadio)
                    : null!
            };
        }
    }
}

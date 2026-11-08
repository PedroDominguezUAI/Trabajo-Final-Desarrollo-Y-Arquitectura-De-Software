using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Mapper
{
    public static class EntradaMapper
    {
         
        public static Entity.EntradaEntity Map(Entity.EFModel.Entrada entradaEF)
        {
            if (entradaEF == null) return null!;

            return new Entity.EntradaEntity
            {
                IdEntrada = entradaEF.IdEntrada,
                Sector = entradaEF.Sector,
                Asiento = entradaEF.Asiento,
                Precio = entradaEF.Precio,
                FechaAsignacion = entradaEF.FechaAsignacion,
                 
                Evento = entradaEF.IdEventoNavigation != null
                    ? EventoMapper.Map(entradaEF.IdEventoNavigation)
                    : null!, 
                Usuario = entradaEF.IdUsuarioNavigation != null
                    ? UsuarioMapper.Map(entradaEF.IdUsuarioNavigation)
                    : null
            };
        }

        public static Entity.EFModel.Entrada Map(Entity.EntradaEntity entradaEntity)
        {
            if (entradaEntity == null) return null!;

            return new Entity.EFModel.Entrada
            {
                IdEntrada = entradaEntity.IdEntrada,
                Sector = entradaEntity.Sector,
                Asiento = entradaEntity.Asiento,
                Precio = entradaEntity.Precio,
                FechaAsignacion = entradaEntity.FechaAsignacion,
                IdEvento = entradaEntity.Evento != null ? entradaEntity.Evento.IdEvento : 0,
                IdUsuario = entradaEntity.Usuario?.IdUsuario,
                IdEventoNavigation = null!,
                IdUsuarioNavigation = null
            };
        }
        public static List<EntradaEntity> Map (List<Entrada> entradas)
        {
            List<EntradaEntity> entradaEntities= new List<EntradaEntity> ();
            foreach(var entrada in entradas)
            {
                entradaEntities.Add(Map(entrada));
            }
            return entradaEntities;
        }
    }
}
using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class EventoDao
    {
        public List<EventoEntity> ObtenerTodos()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Evento> eventos = db.Evento
                        .Include(e => e.IdEstadioNavigation)
                        .ToList();

                    return EventoMapper.Map(eventos);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public EventoEntity ObtenerPorId(int idEvento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Evento evento = db.Evento
                        .Include(e => e.IdEstadioNavigation)
                        .FirstOrDefault(e => e.IdEvento == idEvento);

                    if (evento != null)
                    {
                        return EventoMapper.Map(evento);
                    }
                    return null;
                }
            }
            catch (Exception ex) { throw; }
        }

        public void Guardar(EventoEntity eventoEntity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Evento nuevo = EventoMapper.Map(eventoEntity);
                    db.Evento.Add(nuevo);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Modificar(EventoEntity eventoEntity)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Evento eventoDb = db.Evento.FirstOrDefault(e => e.IdEvento == eventoEntity.IdEvento);
                    if (eventoDb == null)
                    {
                        throw new Exception("El evento a modificar no existe en la base de datos.");
                    }

                    eventoDb.NombreEvento = eventoEntity.NombreEvento;
                    eventoDb.FechaEvento = eventoEntity.FechaEvento;
                    eventoDb.IdEstadio = eventoEntity.Estadio != null ? eventoEntity.Estadio.IdEstadio : 0;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Eliminar(int idEvento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Evento eventoDb = db.Evento.FirstOrDefault(e => e.IdEvento == idEvento);
                    if (eventoDb != null)
                    {
                        db.Evento.Remove(eventoDb);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

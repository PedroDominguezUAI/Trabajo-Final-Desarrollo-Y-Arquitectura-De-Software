using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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

        public bool DuplicidadEventos(EventoEntity evento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    bool Duplicidad = db.Evento.Any(E => E.NombreEvento == evento.NombreEvento && E.FechaEvento.Date == evento.FechaEvento.Date);
                    return Duplicidad;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool SinCambios(EventoEntity evento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    var actual = db.Evento.FirstOrDefault(e => e.IdEvento == evento.IdEvento);
                    if (actual == null)
                    {
                        return false;
                    }

                    string nombreActual = (actual.NombreEvento ?? string.Empty).Trim().ToLower();
                    string nombreNuevo = (evento.NombreEvento ?? string.Empty).Trim().ToLower();

                    bool mismoNombre = nombreActual == nombreNuevo;
                    bool mismaFecha = actual.FechaEvento == evento.FechaEvento;
                    bool mismoEstadio = actual.IdEstadio == evento.Estadio.IdEstadio;

                    return mismoNombre && mismaFecha && mismoEstadio;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool DuplicidadEventosModificar(EventoEntity evento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    bool Duplicidad = db.Evento.Any(E => E.IdEvento != evento.IdEvento && E.NombreEvento == evento.NombreEvento && E.FechaEvento.Date == evento.FechaEvento.Date &&
                    E.FechaEvento.Hour == evento.FechaEvento.Hour &&E.FechaEvento.Minute == evento.FechaEvento.Minute);
                    return Duplicidad;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool ValidarEntradasVendidas(EventoEntity evento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    bool validarEntradas = db.Entrada.Any(E => E.IdEvento == evento.IdEvento);
                    return validarEntradas;
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

        public bool VerificarEntradasEliminar(EventoEntity evento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    return db.Entrada.Any(e => e.IdEvento == evento.IdEvento);
                }
            }
            catch (Exception)
            {
                throw;
            }
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

        public bool ValidarFranjaHoraria(EventoEntity evento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    int duracionHoras = 24;
                    DateTime LimiteInferior = evento.FechaEvento.AddHours(-duracionHoras);
                    DateTime LimiteSuperior = evento.FechaEvento.AddHours(duracionHoras);
                    bool ExisteSolapamiento = db.Evento.Any(E => E.IdEstadio == evento.Estadio.IdEstadio && E.FechaEvento > LimiteInferior && E.FechaEvento < LimiteSuperior);
                    return ExisteSolapamiento;
                }
            }catch (Exception ex)
            {
                throw;
            }
        }
        
        public bool ValidarFranjaHorariaModificar(EventoEntity evento)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    int duracionHoras = 4;
                    DateTime limiteInferior = evento.FechaEvento.AddHours(-duracionHoras);
                    DateTime limiteSuperior = evento.FechaEvento.AddHours(duracionHoras);

                    bool existeSolapamiento = db.Evento.Any(e =>
                        e.IdEvento != evento.IdEvento &&
                        e.IdEstadio == evento.Estadio.IdEstadio &&
                        e.FechaEvento > limiteInferior &&
                        e.FechaEvento < limiteSuperior);

                    return existeSolapamiento;
                }
            }
            catch (Exception)
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

        // Empieza el apartado de ESTADIO
        public List<EstadioEntity> ObtenerEstadios()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    return db.Estadio
                             .Select(s => new EstadioEntity
                             {
                                 IdEstadio = s.IdEstadio,
                                 Nombre = s.Nombre,
                                 Direccion = s.Direccion,
                                 Capacidad = s.Capacidad
                             })
                             .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

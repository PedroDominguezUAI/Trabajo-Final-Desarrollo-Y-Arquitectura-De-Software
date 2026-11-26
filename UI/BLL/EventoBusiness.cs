using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Transactions;

namespace BLL
{
    public class EventoBusiness
    {
        private EventoDao eventoDao = new EventoDao();

        public List<EventoEntity> ObtenerTodos()
        {
            try
            {
                return eventoDao.ObtenerTodos();
            }
            catch (Exception) { throw; }
        }

        public EventoEntity ObtenerPorId(int idEvento)
        {
            try
            {
                if (idEvento <= 0)
                {
                    throw new Exception("El ID de evento no es válido.");
                }

                return eventoDao.ObtenerPorId(idEvento);
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void ValidarReglasDeNegocio(EventoEntity evento)
        {
            if (evento == null)
            {
                throw new Exception("El evento no puede ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(evento.NombreEvento) || evento.NombreEvento.Trim().Length < 3)
            {
                throw new Exception("El nombre del evento debe tener al menos 3 caracteres.");
            }

            if (evento.NombreEvento.Length > 100)
            {
                throw new Exception("El evento no puede tener mas de 100 caracteres");
            }

            if (evento.FechaEvento <= DateTime.Now)
            {
                throw new Exception("La fecha del evento debe ser posterior a la fecha y hora actual.");
            }

            if (evento.Estadio == null || evento.Estadio.IdEstadio <= 0)
            {
                throw new Exception("Debe seleccionar un estadio válido para el evento.");
            }
            
        }

        public void Guardar(EventoEntity evento)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    ValidarReglasDeNegocio(evento);
                    if (eventoDao.DuplicidadEventos(evento))
                    {
                        throw new Exception("Ya existe un evento con ese nombre y fecha");
                    }
                    if (eventoDao.ValidarFranjaHoraria(evento))
                    {
                        throw new Exception("No se puede crear un evento ya que existe un evento en esa franja horaria(debe haber 24 horas de diferencia)");
                    }
                    eventoDao.Guardar(evento);
                    scope.Complete();
                }
                    
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Modificar(EventoEntity evento)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (evento.IdEvento <= 0)
                    {
                        throw new Exception("El ID del evento a modificar no es válido.");
                    }

                    if (eventoDao.SinCambios(evento))
                    {
                        throw new Exception("No se detectaron cambios para modificar el evento.");
                    }

                    if (eventoDao.ValidarFranjaHorariaModificar(evento))
                    {
                        throw new Exception("No se puede modificar el evento a esa fecha ya que no esta disponible en ese horario(debe haber 24 horas de diferencia)");
                    }

                    EventoEntity existente = eventoDao.ObtenerPorId(evento.IdEvento);
                    if (existente == null)
                    {
                        throw new Exception("El evento seleccionado no existe en el sistema.");
                    }

                    if (eventoDao.DuplicidadEventosModificar(evento))
                    {
                        throw new Exception("Debes modificar la fecha y el nombre del evento");
                    }
                    bool cambioEstadio = existente.Estadio.IdEstadio != evento.Estadio.IdEstadio;
                    if (cambioEstadio && eventoDao.ValidarEntradasVendidas(evento))
                    {
                        throw new Exception("No se permite cambiar el estadio de un evento que ya tiene entradas vendidas");
                    }
                    ValidarReglasDeNegocio(evento);
                    eventoDao.Modificar(evento);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Eliminar(int idEvento)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (idEvento <= 0)
                    {
                        throw new Exception("El ID del evento a eliminar no es válido.");
                    }

                    if (eventoDao.ObtenerPorId(idEvento) == null)
                    {
                        throw new Exception("No se encontro el evento en la base de datos");
                    }
                    EventoEntity existente = eventoDao.ObtenerPorId(idEvento);
                    if (existente == null)
                    {
                        throw new Exception("El evento a eliminar no existe en el sistema.");
                    }
                    if (existente.FechaEvento <= DateTime.Now)
                    {
                        throw new Exception("No se permite eliminar eventos antiguos, para no perder historial");
                    }
                    if (eventoDao.VerificarEntradasEliminar(existente))
                    {
                        throw new Exception("No se permite eliminar eventos con entradas asociadas");
                    }
                    eventoDao.Eliminar(idEvento);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Empieza el apartado de ESTADIO
        public List<EstadioEntity> ObtenerEstadios()
        {
            try
            {
                return eventoDao.ObtenerEstadios();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}

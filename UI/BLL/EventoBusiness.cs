using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

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
                ValidarReglasDeNegocio(evento);
                eventoDao.Guardar(evento);
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
                if (evento.IdEvento <= 0)
                {
                    throw new Exception("El ID del evento a modificar no es válido.");
                }

                EventoEntity existente = eventoDao.ObtenerPorId(evento.IdEvento);
                if (existente == null)
                {
                    throw new Exception("El evento seleccionado no existe en el sistema.");
                }

                ValidarReglasDeNegocio(evento);
                eventoDao.Modificar(evento);
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
                if (idEvento <= 0)
                {
                    throw new Exception("El ID del evento a eliminar no es válido.");
                }

                EventoEntity existente = eventoDao.ObtenerPorId(idEvento);
                if (existente == null)
                {
                    throw new Exception("El evento a eliminar no existe en el sistema.");
                }

                eventoDao.Eliminar(idEvento);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}

using DAL;
using DAL.Models;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BLL
{
    public class EstadioBusiness
    {
        EstadioDAO eDao = new EstadioDAO();
        public List<EstadioEntity> getAll()
        {
            try
            {
                return eDao.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AgregarEstadio(EstadioEntity estadio)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    validaciones(estadio);
                    if (eDao.DetectarEstadioNombre(estadio))
                    {
                        throw new Exception("No pueden existir dos estadios con el mismo nombre");
                    }
                    if (eDao.DetectarEstadioDireccion(estadio))
                    {
                        throw new Exception("No pueden existir dos estadios con la misma direccion");
                    }
                    eDao.AgregarEstadio(estadio);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        

        public void validaciones(EstadioEntity estadio)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(estadio.Nombre) || string.IsNullOrWhiteSpace(estadio.Direccion) || string.IsNullOrWhiteSpace(estadio.Capacidad.ToString()))
                {
                    throw new Exception("Los valores cargados deben tener contenido o no deben tener unicamente espacios");
                }
                if (estadio.Capacidad < 10 && estadio.Capacidad > 1000000)
                {
                    throw new Exception("La capacidad del estadio debe ser de entre 10 a 1000000 personas");
                }
                if (estadio.Nombre.Length < 2 || estadio.Nombre.Length > 50)
                {
                    throw new Exception("El nombre del estadio debe tener entre 2 a 50 caracteres");
                }
                if (estadio.Direccion.Length < 4 || estadio.Direccion.Length > 70)
                {
                    throw new Exception("La direccion debe tener entre 4 a 70 caracteres");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public EstadioEntity ObtenerIdEstadio(int ID)
        {
            try
            {
                if (eDao.EncontrarExistencia(ID))
                {
                    throw new Exception("No se encontro el estadio guardado");
                }
                else
                {
                    return eDao.ObtenerIDEstadio(ID);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarEstadio(EstadioEntity estadio)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (eDao.ValidarCambios(estadio))
                    {
                        throw new Exception("No hay cambios, debe generar algun cambio");
                    }
                    if (eDao.DetectarEstadioNombreModificar(estadio))
                    {
                        throw new Exception("No pueden existir dos estadios con el mismo nombre");
                    }
                    if (eDao.DetectarEstadioDireccionModificar(estadio))
                    {
                        throw new Exception("No pueden existir dos estadios con la misma direccion");
                    }
                    validaciones(estadio);
                    eDao.ModificarEstadio(estadio);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarID(int ID)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {

                    if (eDao.EncontrarExistencia(ID))
                    {
                        throw new Exception("Debe existir el estadio para poder eliminarlo, Prueba otro ID");
                    }
                    if (eDao.EncontrarEventos(ID))
                    {
                        throw new Exception("No debe tener eventos asociados para poder ser eliminado");
                    }
                    eDao.EliminarId(ID);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

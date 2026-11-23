using DAL;
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
                    
                    eDao.AgregarEstadio(estadio);
                    scope.Complete();
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
                    return eDao.ObtenerIDEstadio(ID);
                }
                else
                {
                    return null;
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
                        eDao.EliminarId(ID);
                    }
                    else
                    {
                        throw new Exception("Debe existir el estadio para poder eliminarlo, Prueba otro ID");
                    }
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

using DAL;
using Entity;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BLL
{
    public class EntradaBusiness
    {
        EntradaDAO eDao = new EntradaDAO();
        public List<EntradaEntity> getAll()
        {
            try {
                return eDao.getAll();
            }
            catch (Exception ex) {
                throw;
            }
        }

        public void AgregarEntradaBLL(EntradaEntity entrada)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (string.IsNullOrWhiteSpace(entrada.Asiento) || string.IsNullOrWhiteSpace(Convert.ToString(entrada.Precio)))
                    {
                        throw new Exception("Debes rellenar los valores para poder agregar una entrada");
                    }
                    if (entrada.Precio < 10)
                    {
                        throw new Exception("El precio debe ser mayor a 10 dolares");
                    }
                    if (entrada.Precio > 10000000)
                    {
                        throw new Exception("Una entrada no puede valer mas de 10 millones de dolares");
                    }
                    if (entrada.Asiento.Length > 6)
                    {
                        throw new Exception("Los caracteres maximos para un asiento son 6");
                    }
                    if (eDao.DuplicidadAsientoAgregar(entrada))
                    {
                        throw new Exception("El asiento de este evento ya esta ocupado");
                    }
                    entrada.FechaAsignacion = DateTime.Now;
                    eDao.AgregarEntrada(entrada);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public EntradaEntity ObtenerIdEntradaBLL(int ID)
        {
            try
            {
                if (eDao.EncontrarExistencia(ID))
                {
                    return eDao.ObtenerIDEntrada(ID);
                }
                else
                {
                    throw new Exception("Debe existir el usuario, Prueba otro ID");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarEntradaBLL(EntradaEntity entrada)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (string.IsNullOrWhiteSpace(entrada.Asiento) || string.IsNullOrWhiteSpace(Convert.ToString(entrada.Precio)))
                    {
                        throw new Exception("Debes rellenar los valores para poder agregar una entrada");
                    }
                    if (eDao.CambiosRealizado(entrada))
                    {
                        throw new Exception("No has realizado ningun cambio");
                    }
                    if (entrada.Precio < 10)
                    {
                        throw new Exception("El precio debe ser mayor a 10 dolares");
                    }
                    if (entrada.Precio > 10000000)
                    {
                        throw new Exception("Una entrada no puede valer mas de 10 millones de dolares");
                    }
                    if (entrada.Asiento.Length > 6)
                    {
                        throw new Exception("Los caracteres maximos para un asiento son 6");
                    }
                    if (eDao.DuplicidadAsientoAgregarModificar(entrada))
                    {
                        throw new Exception("El asiento de este evento ya esta ocupado");
                    }
                    eDao.ModificarEntrada(entrada);
                    scope.Complete();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void EliminarIDBLL(int ID)
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
                        throw new Exception("Debe existir el usuario para poder eliminarlo, Prueba otro ID");
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

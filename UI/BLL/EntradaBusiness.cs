using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

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
                entrada.FechaAsignacion = DateTime.Now;
                eDao.AgregarEntrada(entrada);
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
                return eDao.ObtenerIDEntrada(ID);
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
                eDao.ModificarEntrada(entrada);
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
                eDao.EliminarId(ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

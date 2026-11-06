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
    }
}

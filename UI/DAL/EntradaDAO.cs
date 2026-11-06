using DAL.Models;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;
using Mapper;
namespace DAL
{
    public class EntradaDAO
    {


        public List<Entity.EntradaEntity> getAll()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Entrada> entradas = db.Entrada
                        .ToList();
                    return EntradaMapper.Map(entradas);
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}

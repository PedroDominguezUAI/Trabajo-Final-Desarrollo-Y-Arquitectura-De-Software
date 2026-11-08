using DAL.Models;
using Entity.EFModel;
using System;
using System.Collections.Generic;
using System.Text;
using Mapper;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
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
                        .Include(e => e.IdEventoNavigation)
                        .Include(e => e.IdUsuarioNavigation)
                        .ToList();
                    return EntradaMapper.Map(entradas);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AgregarEntrada(EntradaEntity entrada)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Entrada e = EntradaMapper.Map(entrada);
                    db.Entrada.Add(e);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public EntradaEntity ObtenerIDEntrada(int ID)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Entrada e = db.Entrada
                        .Include(e => e.IdEventoNavigation)
                        .Include(e => e.IdUsuarioNavigation)
                        .FirstOrDefault(e => e.IdEntrada == ID)
                        ;
                    if (e.IdEntrada != null)
                    {
                        return EntradaMapper.Map(e);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarEntrada(EntradaEntity entrada)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Entrada e = db.Entrada.FirstOrDefault(e => e.IdEntrada == entrada.IdEntrada);
                    if (e != null)
                    {
                        e.IdEvento = entrada.Evento.IdEvento;
                        e.IdUsuario = entrada.Usuario.IdUsuario;
                        e.Asiento = entrada.Asiento;
                        e.Precio = entrada.Precio;
                        e.Sector = entrada.Sector;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarId(int ID)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Entrada e = db.Entrada.FirstOrDefault(e => e.IdEntrada == ID);
                    if (e != null)
                    {
                        db.Entrada.Remove(e);
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

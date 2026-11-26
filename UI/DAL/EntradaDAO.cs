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

        public bool CambiosRealizado(EntradaEntity entrada)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    bool igual = db.Entrada.Any(E => E.IdEntrada == entrada.IdEntrada && E.Asiento == entrada.Asiento && E.Precio == entrada.Precio && E.Sector == entrada.Sector && E.IdEvento == entrada.Evento.IdEvento && E.IdUsuario == entrada.Usuario.IdUsuario);
                    return igual;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool DuplicidadAsientoAgregar(EntradaEntity entrada)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    bool DuplicidadAsientos = db.Entrada.Any(E => E.Asiento == entrada.Asiento && E.IdEvento == entrada.Evento.IdEvento && E.Sector == entrada.Sector);
                    return DuplicidadAsientos;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool DuplicidadAsientoAgregarModificar(EntradaEntity entrada)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    bool DuplicidadAsientos = db.Entrada.Any(E => E.IdEntrada != entrada.IdEntrada &&E.Asiento == entrada.Asiento && E.IdEvento == entrada.Evento.IdEvento && E.Sector == entrada.Sector);
                    return DuplicidadAsientos;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
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

        public bool EncontrarExistencia(int ID)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Entrada? entrada = db.Entrada.FirstOrDefault(E => E.IdEntrada == ID);
                    if (entrada != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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

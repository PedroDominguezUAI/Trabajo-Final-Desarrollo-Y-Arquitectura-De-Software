using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class EstadioDAO
    {
          public List<Entity.EstadioEntity> getAll()
            {
                try
                {
                    using (var db = new ModeloParcialContext())
                    {
                        List<Estadio> estadios = db.Estadio
                            .ToList();
                        return EstadioMapper.Map(estadios);
                    }

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
                    using (var db = new ModeloParcialContext())
                    {
                        Estadio e = EstadioMapper.Map(estadio);
                        db.Estadio.Add(e);
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
                        Estadio? estadio = db.Estadio.FirstOrDefault(E => E.IdEstadio == ID);
                        if (estadio != null)
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

            public EstadioEntity ObtenerIDEstadio(int ID)
            {
                try
                {
                    using (var db = new ModeloParcialContext())
                    {
                        Estadio e = db.Estadio
                            .FirstOrDefault(e => e.IdEstadio == ID)
                            ;
                        if (e.IdEstadio != null)
                        {
                            return EstadioMapper.Map(e);
                        }
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
                    using (var db = new ModeloParcialContext())
                    {
                        Estadio e = db.Estadio.FirstOrDefault(e => e.IdEstadio == estadio.IdEstadio);
                        if (e != null)
                        {
                            e.Nombre = estadio.Nombre;
                            e.Direccion = estadio.Direccion;
                            e.Capacidad = estadio.Capacidad; 
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
                        Estadio e = db.Estadio.FirstOrDefault(e => e.IdEstadio == ID);
                        if (e != null)
                        {
                            db.Estadio.Remove(e);
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

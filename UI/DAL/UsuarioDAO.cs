using DAL.Models;
using Entity;
using Entity.EFModel;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Text;

namespace DAL
{
    public class UsuarioDAO
    {
        public bool EntradasVIgentes(int id)
        {
            try
            {
                using (var DB = new ModeloParcialContext())
                {
                    DateTime NOW = DateTime.Now;
                    bool TieneEntradasVigentes = DB.Entrada.Any(E => E.IdUsuario == id && E.IdEventoNavigation.FechaEvento >= NOW);
                    return TieneEntradasVigentes;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool MismoEmail(string Email)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Usuario? usuario = db.Usuario.FirstOrDefault(U => U.Email == Email);
                    if (usuario != null)
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

        public bool SinModificarValores(UsuarioEntity usuario)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    bool sinModificar = db.Usuario.Any(U => U.IdUsuario == usuario.IdUsuario && U.Apellido == usuario.Apellido && U.Dni == usuario.Dni && U.Email == usuario.Email && U.Nombre == usuario.Nombre && U.NombreUsuario == usuario.NombreUsuario && U.Password == usuario.Password);
                    return sinModificar;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool DetectarNombreUsuarioConid(UsuarioEntity usuario)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Usuario? usuarioEncontrado = db.Usuario.FirstOrDefault(U => U.IdUsuario != usuario.IdUsuario && U.NombreUsuario == usuario.NombreUsuario);
                    if (usuarioEncontrado != null)
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
        public bool EncontrarDNIConId(UsuarioEntity usuario)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Usuario? usuarioEncontrado = db.Usuario.FirstOrDefault(U => U.IdUsuario != usuario.IdUsuario && U.Dni == usuario.Dni);
                    if (usuarioEncontrado != null)
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
        public bool MismoEmailConId(UsuarioEntity usuario)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Usuario? usuarioEncontrado = db.Usuario.FirstOrDefault(U => U.IdUsuario != usuario.IdUsuario && U.Email == usuario.Email);
                    if (usuarioEncontrado != null)
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
        public void agregarUsuario(UsuarioEntity usuario)
        {
            try
            {
                using (var db= new ModeloParcialContext())
                {
                    Usuario usuarioNuevo = UsuarioMapper.Map(usuario);
                    db.Usuario.Add(usuarioNuevo);
                    db.SaveChanges();
                }
            }
            catch(Exception ex) 
            {
                throw;
            }
        }

        public bool EncontrarDNI(string Dni)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Usuario? usuario = db.Usuario.FirstOrDefault(U => U.Dni == Dni);
                    if (usuario != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public bool DetectarNombreUsuario(string nombreUsuario)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    Usuario? usuario = db.Usuario.FirstOrDefault(U => U.NombreUsuario == nombreUsuario);
                    if (usuario != null)
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
        public UsuarioEntity buscarID(int id)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {

                    Usuario usuario = db.Usuario.FirstOrDefault(e => e.IdUsuario == id);
                    if (usuario != null)
                    {
                        return UsuarioMapper.Map(usuario);
                    }
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public UsuarioEntity LogIn(string nombreUsuario, string password)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                     
                    Usuario usuario = db.Usuario
                        .Include(u => u.IdTipoNavigation)
                        .FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Password == password);

                    if (usuario != null)
                    { 
                        return UsuarioMapper.Map(usuario);
                    }  
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void eliminarUsuario(int id)
        {
            try
            {
                using (var db = new ModeloParcialContext()) { 
                
                    Usuario usuario = db.Usuario.FirstOrDefault(e => e.IdUsuario == id);
                    if (usuario != null)
                    {
                        db.Usuario.Remove(usuario);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) {
                throw;
            }

        }
        public void modificarUsuario(UsuarioEntity usuario)
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    
                    Usuario usuarioEF = db.Usuario.FirstOrDefault(e => e.IdUsuario == usuario.IdUsuario);

                    if (usuarioEF != null)
                    {
                         
                        usuarioEF.NombreUsuario = usuario.NombreUsuario;
                        usuarioEF.Password = usuario.Password;
                        usuarioEF.Nombre = usuario.Nombre;
                        usuarioEF.Apellido = usuario.Apellido;
                        usuarioEF.Dni = usuario.Dni;
                        usuarioEF.Email = usuario.Email;
                         
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<UsuarioEntity> getAll()
        {
            try
            {
                using (var db = new ModeloParcialContext())
                {
                    List<Usuario> usuarios = db.Usuario.ToList();
                    List<Usuario> usuarioClientes = new List<Usuario>();
                    foreach (Usuario usuario in usuarios)
                    {
                        if (usuario.IdTipo == 2)
                        {
                            usuarioClientes.Add(usuario);
                        }
                    }
                    return UsuarioMapper.Map(usuarioClientes);
                }

            }
            catch( Exception ex ) 
            {
                throw;

            }
        }
    }

}

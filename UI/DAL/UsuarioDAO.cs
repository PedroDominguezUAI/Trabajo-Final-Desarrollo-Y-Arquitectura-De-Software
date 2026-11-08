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
                using(var db = new ModeloParcialContext())
                {
                    List<Usuario>  usuarios = db.Usuario.ToList();
                    return UsuarioMapper.Map(usuarios);
                }

            }
            catch( Exception ex ) 
            {
                throw;

            }
        }
    }

}

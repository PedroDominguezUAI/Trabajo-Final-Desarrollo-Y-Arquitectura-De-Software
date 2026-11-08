using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class UsuarioBusiness
    {
        UsuarioDAO uDAO = new UsuarioDAO();
        public void agregarUsuario(UsuarioEntity usuario)
        {
            try
            {
                //Falta validaciones
                uDAO.agregarUsuario(usuario);
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
                return uDAO.LogIn(nombreUsuario, password);
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
                uDAO.buscarID(id);
                if(id  == null)
                {
                    throw new Exception("ID Invalido");
                }
                uDAO.eliminarUsuario(id);

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void modificarUsuario(UsuarioEntity usuario)
        {
            try
            {
                uDAO.buscarID(usuario.IdUsuario);
                if (usuario.IdUsuario == null)
                {
                    throw new Exception("ID Invalido");
                }
                uDAO.modificarUsuario(usuario);

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
                return uDAO.getAll();
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
                return uDAO.buscarID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

using DAL;
using Entity;
using Entity.EFModel;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BLL
{
    public class UsuarioBusiness
    {
        UsuarioDAO uDAO = new UsuarioDAO();
        public void agregarUsuario(UsuarioEntity usuario, string RepetirContraseña)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) || string.IsNullOrWhiteSpace(usuario.Password) || string.IsNullOrWhiteSpace(RepetirContraseña) || string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido) || string.IsNullOrWhiteSpace(usuario.Dni) || string.IsNullOrWhiteSpace(usuario.Email))
                    {
                        throw new Exception("Los valores cargados deben tener contenido o no deben tener unicamente espacios");
                    }
                    if (usuario.NombreUsuario.Length < 4 || usuario.NombreUsuario.Length > 20)
                    {
                        throw new Exception("El nombre de usuario debe tener entre 4 a 20 caracteres");
                    }
                    if (!usuario.NombreUsuario.All(c => char.IsLetterOrDigit(c)))
                    {
                        throw new Exception("No debe tener caracteres especiales el nombre de usuario");
                    }
                    if (uDAO.DetectarNombreUsuario(usuario.NombreUsuario))
                    {
                        throw new Exception("Debe cambiar el nombre de usuario, ya esta ocupado en el sistema");
                    }
                    if (usuario.Password.Length < 8 || usuario.Password.Length > 30)
                    {
                        throw new Exception("La contraseña debe tener entre 8 a 30 caracteres");
                    }
                    if (usuario.NombreUsuario == usuario.Password)
                    {
                        throw new Exception("El nombre de usuario debe de ser distinto a la contraseña");
                    }
                    if (!usuario.Password.Any(c => char.IsUpper(c)) || !usuario.Password.Any(c => char.IsLower(c)) || !usuario.Password.Any(c => char.IsDigit(c)))
                    {
                        throw new Exception("Debe contener minimo una mayusucula, minuscula o un numero");
                    }
                    if (usuario.Password != RepetirContraseña)
                    {
                        throw new Exception("Los valores de contraseña y repetir contraseña deben ser iguales");
                    }
                    if (usuario.Nombre.Length < 2 || usuario.Nombre.Length > 50)
                    {
                        throw new Exception("El nombre debe contener entre 2 a 50 caracteres");
                    }
                    if (!usuario.Nombre.All(c => char.IsLetter(c) || c == ' '))
                    {
                        throw new Exception("El nombre solo puede contener letras o espacios");
                    }
                    if (usuario.Apellido.Length < 2 || usuario.Apellido.Length > 50)
                    {
                        throw new Exception("El apellido debe contener entre 2 a 50 caracteres");
                    }
                    if (!usuario.Apellido.All(c => char.IsLetter(c) || c == ' '))
                    {
                        throw new Exception("La contraseña debe contener minimo una mayusucula, minuscula y un numero");
                    }
                    if (!usuario.Dni.All(c => char.IsDigit(c)))
                    {
                        throw new Exception("El dni solo pueden ser numeros");
                    }
                    if (usuario.Dni.Length < 7 || usuario.Dni.Length > 8)
                    {
                        throw new Exception("El DNI debe tener entre 7 a 8 digitos");
                    }
                    if (uDAO.EncontrarDNI(usuario.Dni))
                    {
                        throw new Exception("El DNI no debe existir en la base de datos");
                    }
                    if (usuario.Email.Length > 100)
                    {
                        throw new Exception("El Email puede tener como maximo 100 caracteres");
                    }
                    var EmailVerificacion = new System.Net.Mail.MailAddress(usuario.Email);
                    if (EmailVerificacion.Address != usuario.Email || !usuario.Email.Contains("."))
                    {
                        throw new Exception("El email debe tener la escritura tipica de un mail(usuario@dominio.com), ademas debe contener puntos");
                    }
                    if (uDAO.MismoEmail(usuario.Email))
                    {
                        throw new Exception("Ya existe un mail vinculado a ese usuario");
                    }
                    uDAO.agregarUsuario(usuario);
                    scope.Complete();
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
                using (TransactionScope scope = new TransactionScope())
                {
                    if (string.IsNullOrWhiteSpace(Convert.ToString(id)))
                    {
                        throw new Exception("ID Invalido");
                    }
                    if (uDAO.buscarID(id) == null)
                    {
                        throw new Exception("ID Invalido, no se puede borrar un usuario inexistente");
                    }
                    if (uDAO.EntradasVIgentes(id))
                    {
                        throw new Exception("ID Invalido, no se permite eliminar usuarios con entradas vigentes");
                    }
                    uDAO.eliminarUsuario(id);
                    scope.Complete();
                }
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
                using (TransactionScope scope = new TransactionScope())
                {
                    if (usuario == null)
                    {
                        throw new Exception("ID Invalido");
                    }
                    if (uDAO.SinModificarValores(usuario))
                    {
                        throw new Exception("No hay ningun valor para modificar");
                    }
                    if (usuario.IdUsuario <= 0)
                    {
                        throw new Exception("ID inválido");
                    }
                    if (uDAO.buscarID(usuario.IdUsuario) == null)
                    {
                        throw new Exception("No existe un usuario con ese ID");
                    }
                    if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) || string.IsNullOrWhiteSpace(usuario.Password) || string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido) || string.IsNullOrWhiteSpace(usuario.Dni) || string.IsNullOrWhiteSpace(usuario.Email))
                    {
                        throw new Exception("Los valores cargados deben tener contenido o no deben tener unicamente espacios");
                    }
                    if (usuario.NombreUsuario.Length < 4 || usuario.NombreUsuario.Length > 20)
                    {
                        throw new Exception("El nombre de usuario debe tener entre 4 a 20 caracteres");
                    }
                    if (!usuario.NombreUsuario.All(c => char.IsLetterOrDigit(c)))
                    {
                        throw new Exception("No debe tener caracteres especiales el nombre de usuario");
                    }
                    if (uDAO.DetectarNombreUsuarioConid(usuario))
                    {
                        throw new Exception("Debe cambiar el nombre de usuario, ya esta ocupado en el sistema");
                    }
                    if (usuario.Password.Length < 8 || usuario.Password.Length > 30)
                    {
                        throw new Exception("La contraseña debe tener entre 8 a 30 caracteres");
                    }
                    if (usuario.NombreUsuario == usuario.Password)
                    {
                        throw new Exception("El nombre de usuario debe de ser distinto a la contraseña");
                    }
                    if (!usuario.Password.Any(c => char.IsUpper(c)) || !usuario.Password.Any(c => char.IsLower(c)) || !usuario.Password.Any(c => char.IsDigit(c)))
                    {
                        throw new Exception("La contraseña debe contener minimo una mayusucula, minuscula y un numero");
                    }
                    if (usuario.Nombre.Length < 2 || usuario.Nombre.Length > 50)
                    {
                        throw new Exception("El nombre debe contener entre 2 a 50 caracteres");
                    }
                    if (!usuario.Nombre.All(c => char.IsLetter(c) || c == ' '))
                    {
                        throw new Exception("El nombre solo puede contener letras o espacios");
                    }
                    if (usuario.Apellido.Length < 2 || usuario.Apellido.Length > 50)
                    {
                        throw new Exception("El apellido debe contener entre 2 a 50 caracteres");
                    }
                    if (!usuario.Apellido.All(c => char.IsLetter(c) || c == ' '))
                    {
                        throw new Exception("El apellido solo puede contener letras o espacios");
                    }
                    if (!usuario.Dni.All(c => char.IsDigit(c)))
                    {
                        throw new Exception("El dni solo pueden ser numeros");
                    }
                    if (usuario.Dni.Length < 7 || usuario.Dni.Length > 8)
                    {
                        throw new Exception("El DNI debe tener entre 7 a 8 digitos");
                    }
                    if (uDAO.EncontrarDNIConId(usuario))
                    {
                        throw new Exception("El DNI no debe existir en la base de datos");
                    }
                    if (usuario.Email.Length > 100)
                    {
                        throw new Exception("El Email puede tener como maximo 100 caracteres");
                    }
                    var EmailVerificacion = new System.Net.Mail.MailAddress(usuario.Email);
                    if (EmailVerificacion.Address != usuario.Email || !usuario.Email.Contains("."))
                    {
                        throw new Exception("El email debe tener la escritura tipica de un mail(usuario@dominio.com), ademas debe contener puntos");
                    }
                    if (uDAO.MismoEmailConId(usuario))
                    {
                        throw new Exception("Ya existe un mail vinculado a ese usuario");
                    }
                    uDAO.modificarUsuario(usuario);
                    scope.Complete();
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
                if (string.IsNullOrWhiteSpace(Convert.ToString(id)))
                {
                    throw new Exception("ID Invalido");
                }
                if (uDAO.buscarID(id) == null)
                {
                    throw new Exception("No existe ese ID, debes cambiarlo");
                }
                return uDAO.buscarID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

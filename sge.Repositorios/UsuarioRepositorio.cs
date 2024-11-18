using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using sge.Aplicacion;
using SQLitePCL;

namespace sge.Repositorios
{
    public class UsuarioRepositorio (DataContext db) : IUsuarioRepositorio
    {

        public Usuario agregarUsuario(Usuario usuario)
        {
            if (!db.Users.Any()) // Si no hay usuario, el primero es el admin 
            {
                usuario.Admin = true;
            }

            if (usuario.Admin)
            {
                var permisos = Enum.GetNames(typeof(Permiso));
                var aux = string.Join(",", permisos);
                usuario.Perm = aux;
            }
            else
            {
                var permisosNoAdmin = new List<Permiso>()
                {
                    Permiso.LecturaGeneral
                };
                var permisosString = string.Join(",", permisosNoAdmin.Select(p => p.ToString()));
                usuario.Perm = permisosString;
            }

            db.Users.Add(usuario);
            db.SaveChanges();
            return usuario;
        }

        public Usuario? buscarUsuarioPorMail(string email)
        {
            return db.Users.FirstOrDefault(u => u.Mail == email);
        }

        public Usuario? buscarUsuario(int IdUser)
        {
            return db.Users.FirstOrDefault(u => u.Id == IdUser);
        }

        public List<Usuario> listarUsuarios()
        {
            return db.Users.ToList();
        }
        public void EliminarUsuario(int IdUser)
        {
            var usuario = db.Users.Find(IdUser);
            if (usuario != null)
            {
                db.Users.Remove(usuario);
                db.SaveChanges();
            }
        }

        public void ModificarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                usuario.Password = Hasheador.hashear(usuario.Password);
                db.Users.Update(usuario);
                db.SaveChanges();
            }
        }

        public bool conseguirDatos(string email, string password)
        {
            var usuario = db.Users.FirstOrDefault(u => u.Mail == email);
            if (usuario != null)
            {
                string? aux = usuario.Password;
                string hash = Hasheador.hashear(password);
                return aux == hash;
            }
            return false;
        }
    }
}
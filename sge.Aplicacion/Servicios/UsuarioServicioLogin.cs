using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sge.Aplicacion;

namespace sge.Repositorios;

    public class UsuarioServicioLogin
    {
        public Usuario usuario {get; set;}= null!;
        public bool EstaLogeado {get;set;}= false;

        public void SetUser(Usuario user)
        {
            usuario = user;
        }

        public Usuario GetUser()
        {
            if (usuario == null)
          {
            throw new InvalidOperationException("No se pudo obtener el usuario.");
          }
          return usuario;
        }

        public void Logueado()
        {
          EstaLogeado = true;
        }

        public int recuperarID()
        {
          if(usuario != null){
            return usuario.Id;
          }
          return 0;
        }
    }

namespace sge.Aplicacion;
    public class CasoDeUsoUsuarioAlta:CasoDeUsoUsuario
    {
        private readonly UsuarioValidador validador;

         public CasoDeUsoUsuarioAlta(IUsuarioRepositorio repositorio,UsuarioValidador validador)
        : base(repositorio)
        {
            this.validador=validador;
        }
        public void Ejecutar(Usuario usuario)
        {
               if (!validador.Validar(usuario, out string mensajeError))
                {
                        throw new ValidacionException(mensajeError);
                }
                Repositorio.agregarUsuario(usuario);
        }
    }
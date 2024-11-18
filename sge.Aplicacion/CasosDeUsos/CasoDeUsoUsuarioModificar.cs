namespace sge.Aplicacion
{
    public class CasoDeUsoUsuarioModificar:CasoDeUsoUsuario
    {
         public CasoDeUsoUsuarioModificar(IUsuarioRepositorio repositorio)
        : base(repositorio)
        {
        }
        public void Ejecutar(Usuario usuario)
        {
          Repositorio.ModificarUsuario(usuario);
        }
    }
}
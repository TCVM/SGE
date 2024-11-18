namespace sge.Aplicacion
{
    public class CasoDeUsoUsuarioBuscarPorUsuario:CasoDeUsoUsuario
    {
       public CasoDeUsoUsuarioBuscarPorUsuario(IUsuarioRepositorio repositorio)
        : base(repositorio)
      {
      }
      public Usuario? Ejecutar(int IdUser)
      {
        return Repositorio.buscarUsuario(IdUser);
      }
    }
}
namespace sge.Aplicacion
{
    public class CasoDeUsoUsuarioBuscarPorMail:CasoDeUsoUsuario
    {
    
    public CasoDeUsoUsuarioBuscarPorMail(IUsuarioRepositorio repositorio)
        : base(repositorio)
    {
    }
    public Usuario Ejecutar(string email)
      {
        Usuario u= Repositorio.buscarUsuarioPorMail(email)!;
        return u;
      }
    }
}
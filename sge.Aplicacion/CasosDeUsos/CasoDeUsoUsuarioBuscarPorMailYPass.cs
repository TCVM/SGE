namespace sge.Aplicacion
{
    public class CasoDeUsoUsuarioBuscarPorMailYPass:CasoDeUsoUsuario
    { 
       public CasoDeUsoUsuarioBuscarPorMailYPass(IUsuarioRepositorio repositorio)
        : base(repositorio)
      {
      }
      public bool Ejecutar(string email, string password)
      {
        return Repositorio.conseguirDatos(email,password);
      }

    }
}
namespace sge.Aplicacion
{
    public class CasoDeUsoIniciarSesion:CasoDeUsoUsuario
    {
         public CasoDeUsoIniciarSesion(IUsuarioRepositorio repositorio)
        : base(repositorio)
      {
      }
        public bool Ejecutar(string email, string password)
        {
          return Repositorio.conseguirDatos(email,password);
        }
    }
}
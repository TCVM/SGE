namespace sge.Aplicacion
{
    public class CasoDeUsoUsuarioBaja:CasoDeUsoUsuario
    {
         public CasoDeUsoUsuarioBaja(IUsuarioRepositorio repositorio)
        : base(repositorio)
    {
    }
        public void Ejecutar(int id)
        {
            Repositorio.EliminarUsuario(id);
        }
    }
}
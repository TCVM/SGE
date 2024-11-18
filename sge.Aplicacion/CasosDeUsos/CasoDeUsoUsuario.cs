namespace sge.Aplicacion
{
    public abstract class CasoDeUsoUsuario
    {
        protected IUsuarioRepositorio Repositorio { get; }
    
        protected CasoDeUsoUsuario(IUsuarioRepositorio repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
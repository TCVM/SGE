namespace sge.Aplicacion
{
    public class CasoDeUsoUsuarioListar:CasoDeUsoUsuario
    {
         public CasoDeUsoUsuarioListar(IUsuarioRepositorio repositorio)
        : base(repositorio)
    {
    }
        public List<Usuario> Ejecutar()
        {
            return Repositorio.listarUsuarios();
        }
    }
}
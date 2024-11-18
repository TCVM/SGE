namespace sge.Aplicacion;

public interface ITramiteRepositorio
{
    public void agregarTramite(Tramite tramite);
    public void modificarTramite(Tramite tram, int idUser, string contenido);
    public void bajaTramite(int id);
    public Tramite getTRAMporID(int id);
    //public bool existe(int id);
    public List<Tramite> consultaPorEtiqueta(string etiqueta);
    public List<Tramite> consultaPorIdExp(int idExp);
}

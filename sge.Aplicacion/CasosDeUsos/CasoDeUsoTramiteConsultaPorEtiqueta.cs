using sge.Aplicacion;

public class CasoDeUsoTramiteConsultaPorEtiqueta(ITramiteRepositorio repo)
{
    public List<Tramite> Ejecutar(string etiqueta)
    {
        return repo.consultaPorEtiqueta(etiqueta);
    }
}

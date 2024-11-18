namespace sge.Aplicacion;
public class CasoDeUsoExpedienteConsultaPorId(ITramiteRepositorio repoTram)
{

    public List<Tramite>Ejecutar(int expId){
        
        return repoTram.consultaPorIdExp(expId);
}
}
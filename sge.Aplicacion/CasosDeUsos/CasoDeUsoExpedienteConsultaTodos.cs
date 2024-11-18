namespace sge.Aplicacion;

public class CasoDeUsoExpedienteConsultaTodos(IExpedienteRepositorio repo)
{
    public List<Expediente> Ejecutar()=>repo.listarExpediente();
}
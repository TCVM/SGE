namespace sge.Aplicacion;

public interface IExpedienteRepositorio
{
    public Expediente getEXPporID(int id);
    public void agregarExpediente(Expediente exp);
    public void bajaExpediente(int idExpediente);
    public void modificacionExpediente(int idExpediente,int idUser, string mod);
    public List<Expediente> listarExpediente();
    public void cambiarEstado(Expediente exp);
}

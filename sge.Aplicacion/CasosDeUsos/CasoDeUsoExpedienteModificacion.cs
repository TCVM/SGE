namespace sge.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo,IServicioAutorizacion autorizacion)
{
    public void Ejecutar(int expId,Usuario user,string mod){
        if(autorizacion.poseeElPermiso(user,Permiso.ExpedienteModificacion.ToString())){
                repo.modificacionExpediente(expId, user.Id,mod);
        }
        else
            throw new AutorizacionException();
    }
}
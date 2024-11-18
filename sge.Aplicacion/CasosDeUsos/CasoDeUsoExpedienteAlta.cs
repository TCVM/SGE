namespace sge.Aplicacion;
public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repo,IServicioAutorizacion autorizacion, ExpedienteValidador validador)
{
    public void Ejecutar(Expediente expediente, Usuario user)
     {
        if(autorizacion.poseeElPermiso(user,Permiso.ExpedienteAlta.ToString()))
        {
                if (!validador.Validar(expediente, out string mensajeError))
                {
                        throw new ValidacionException(mensajeError);
                }
                repo.agregarExpediente(expediente);
        }
        else
        {
            throw new AutorizacionException("Autorizacion fallida");
        }
     }
}
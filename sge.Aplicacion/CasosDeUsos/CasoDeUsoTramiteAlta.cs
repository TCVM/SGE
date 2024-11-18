namespace sge.Aplicacion;

public class CasoDeUsoTramiteAlta(ITramiteRepositorio repoT,IExpedienteRepositorio repoE,IServicioAutorizacion autorizacion, TramiteValidador validador, ServicioActualizacionEstado estadoService)
{
    public void Ejecutar(Tramite tramite,Usuario user){
        if (autorizacion.poseeElPermiso(user, Permiso.TramiteAlta.ToString()))
    {

        if (!validador.Validar(tramite, out string mensajeError))
        {
            Console.WriteLine("Error en la validación: " + mensajeError);
            throw new ValidacionException(mensajeError);
        }

        Expediente exp = repoE.getEXPporID(tramite.expedienteId);
        estadoService.Actualizar(exp, tramite.etiqueta);
        repoT.agregarTramite(tramite);
    }
    }
}
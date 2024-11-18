namespace sge.Aplicacion;
public class EspecificacionCambioEstado
{
    public static string Especificar(string? etiqueta_tramite, Expediente exp) {

        string estado = exp.estado;
        switch (etiqueta_tramite)
        {
            //evalua los distintos casos de cambio de estado automático
            case "Resolucion":
                estado = EstadoExpediente.ConResolucion.ToString();
                break;
            case "PasaEstudio":
                estado = EstadoExpediente.ParaResolver.ToString();
                break;
            case "PaseAlArchivo":
                estado = EstadoExpediente.Finalizado.ToString();
                break;
        }
        return estado;
    }
}
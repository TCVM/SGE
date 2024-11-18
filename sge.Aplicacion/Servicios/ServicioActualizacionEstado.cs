namespace sge.Aplicacion;
public class ServicioActualizacionEstado (IExpedienteRepositorio repoE)
{
    public void Actualizar(Expediente expediente, string? et)
    {
        expediente.estado= EspecificacionCambioEstado.Especificar(et, expediente);
        repoE.cambiarEstado(expediente);
    }
        // invoca a especificacion de estado y actualiza estado del expediente
}
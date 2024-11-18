namespace sge.Aplicacion;
public class CasoDeUsoExpedienteBaja(IExpedienteRepositorio repo,ITramiteRepositorio repoTramite,IServicioAutorizacion autorizacion)
{
    public void Ejecutar(int id,Usuario user){
            if(autorizacion.poseeElPermiso(user,Permiso.ExpedienteBaja.ToString()))
            {
                foreach (var trt in repoTramite.consultaPorIdExp(id))//recibe lista de tramites.
                {
                       repoTramite.bajaTramite(trt.Id); //por cada tramite en la lista elimina en el archivo 
                } 
                repo.bajaExpediente(id);
            }
            else
                throw new AutorizacionException();
            }
}
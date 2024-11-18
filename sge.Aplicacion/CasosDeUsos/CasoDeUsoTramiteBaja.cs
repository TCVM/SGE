namespace sge.Aplicacion;
using System.Collections.Generic;

public class CasoDeUsoTramiteBaja(ServicioActualizacionEstado estadoService,ITramiteRepositorio repoT, IExpedienteRepositorio repoE,IServicioAutorizacion autorizacion)
{
    public void Ejecutar(int idTram,Usuario user){
        if(autorizacion.poseeElPermiso(user,Permiso.TramiteModificacion.ToString()))
        {
            Expediente exp=repoE.getEXPporID(repoT.getTRAMporID(idTram).expedienteId);
            List<Tramite> listaTrams=repoT.consultaPorIdExp(repoT.getTRAMporID(idTram).expedienteId);
            if(listaTrams[listaTrams.Count - 1].Id == idTram)     // accede a ultimo elemento y chequea si es mismo id
            {
                if(listaTrams.Count> 1)
                    estadoService.Actualizar(exp,listaTrams[listaTrams.Count-2].etiqueta);   // accede a anteultimo elemento y actualiza
            }
            repoT.bajaTramite(idTram);
        } 
        else
            throw new AutorizacionException();
    }
}
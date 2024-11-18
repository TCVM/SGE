namespace sge.Aplicacion;

public class CasoDeUsoTramiteModificacion(ServicioActualizacionEstado estadoService,ITramiteRepositorio repoT, IExpedienteRepositorio repoE,IServicioAutorizacion autorizacion)
{

    public void Ejecutar(int id,Usuario user,string mod)
    {
        if(autorizacion.poseeElPermiso(user,Permiso.TramiteModificacion.ToString()))
        {
            Tramite tram=repoT.getTRAMporID(id);
            Expediente exp=repoE.getEXPporID(tram.expedienteId);
            repoT.modificarTramite(tram, user.Id,mod);
            List<Tramite> listaTrams=repoT.consultaPorIdExp(tram.expedienteId);
            if(listaTrams[listaTrams.Count -1].Id == tram.Id) //id del ultimo tramite
            {
                estadoService.Actualizar(exp, tram.etiqueta);
            }
        }
        else
            throw new AutorizacionException();
    }
    }

namespace sge.Aplicacion;

public class TramiteValidador
{
    public bool Validar(Tramite tram, out string mensajeError)
    {
        //evalua si un tramite cumple las condiciones para ser agregado
        mensajeError = "";
        if(string.IsNullOrWhiteSpace(tram.contenido))
        {
            mensajeError = "El contenido del expediente no puede estar vacío.\n";
        }
        if(tram.idUltimoUser <= 0) 
        {
            mensajeError += "El id de usuario del tramite debe ser un valor mayor que cero. \n";
        }
        return mensajeError == "";
    }
}
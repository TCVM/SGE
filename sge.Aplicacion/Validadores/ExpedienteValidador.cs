namespace sge.Aplicacion;

public class ExpedienteValidador
{
    public bool Validar(Expediente exp, out string mensajeError)
    {
        //evalua si un expediente cumple las condiciones para ser agregado
        mensajeError = "";
        if (string.IsNullOrWhiteSpace(exp.caratula))
        {
            mensajeError = "La caratula del expediente no puede estar vacia.\n";
        }
        if(exp.idUsuario <= 0) 
        {
            mensajeError += "El id de usuario del expediente debe ser un valor mayor que cero. \n";
        }
        return mensajeError == "";
    }
}
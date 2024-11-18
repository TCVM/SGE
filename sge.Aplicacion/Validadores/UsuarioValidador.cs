namespace sge.Aplicacion;

public class UsuarioValidador
{
    public bool Validar(Usuario user, out string mensajeError)
    {
        //evalua si un Usuario cumple las condiciones para ser agregado
        mensajeError = "";
        if (string.IsNullOrWhiteSpace(user.Password))
        {
            mensajeError = "El contenido de la contraseña no puede estar vacío.\n";
        }
        if (string.IsNullOrWhiteSpace(user.Nombre))
        {
            mensajeError = "El contenido de Nombre no puede estar vacío.\n";
        }
        if (string.IsNullOrWhiteSpace(user.Mail))
        {
            mensajeError = "El contenido de Mail no puede estar vacío.\n";
        }
         if (string.IsNullOrWhiteSpace(user.Apellido))
        {
            mensajeError = "El contenido de Apellido no puede estar vacío.\n";
        }
        return mensajeError == "";
    }
}
namespace sge.Aplicacion;

public class ServicioAutorizacion: IServicioAutorizacion
{
    public bool poseeElPermiso(Usuario user, string permiso)
        {
          if (user != null)
        {
            var permisos = user.Perm?.Split(',');
            if (permisos != null && permisos.Contains(permiso))
            {
                return true;
            }
        }

        return false; // No tiene permiso si no hay usuario o no coinciden los permisos
    }
}
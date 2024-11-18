namespace sge.Aplicacion;

public interface IServicioAutorizacion
{
    bool poseeElPermiso(Usuario user, string permisoX); //la clase Permiso es enum
}

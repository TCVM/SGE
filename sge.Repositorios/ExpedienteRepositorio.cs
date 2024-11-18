namespace sge.Repositorios;
using sge.Aplicacion;

public class ExpedienteRepositorio(DataContext db): IExpedienteRepositorio
{

 public Expediente getEXPporID(int ExpId)
    {
        Expediente? ExpedienteEncontrar = db.Expedientes.FirstOrDefault(a => a.Id == ExpId);
        if (ExpedienteEncontrar != null)
        {
            return ExpedienteEncontrar;
        }
        throw new Exception("Expediente con ID " + ExpId + " no encontrado");
    }

    public void agregarExpediente(Expediente expediente)
    {
        DateTime ahora= DateTime.Now;
        expediente.fechaCreacion= ahora;
        expediente.fechaUltimaModificacion= ahora;
        expediente.estado= EstadoExpediente.RecienIniciado.ToString();
        db.Expedientes.Add(expediente);
        db.SaveChanges(); 
        }

 public void modificacionExpediente(int idExp, int idUser, string cont)
    {
        Expediente? expedienteModificar = db.Expedientes.FirstOrDefault(e => e.Id == idExp);
        if (expedienteModificar != null)
        {
            expedienteModificar.idUsuario= idUser;
            expedienteModificar.fechaUltimaModificacion= DateTime.Now;
            expedienteModificar.caratula = cont; 
        }
        else
            throw new RepositorioException();
        db.SaveChanges();
    }

 public void bajaExpediente(int idExp)
    {
	    using var db = new DataContext();
        var ExpedienteBorrar = db.Expedientes.FirstOrDefault(a => a.Id == idExp);
        if (ExpedienteBorrar != null)
        {
            db.Remove(ExpedienteBorrar);
        }
        else
            throw new RepositorioException();
        db.SaveChanges(); 
}

    public List<Expediente> listarExpediente()
    {
        var resultado = new List<Expediente>();
        using (var context = new DataContext())
        {
            foreach (var a in context.Expedientes)
            {
                resultado.Add(a);
            }
        }
        return resultado;
    }

    public void cambiarEstado(Expediente exp)
    {
        if (exp != null)
        {
            db.SaveChanges();
        }
        else
            throw new RepositorioException();
    }
}
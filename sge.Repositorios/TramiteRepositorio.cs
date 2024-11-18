namespace sge.Repositorios;

using sge.Aplicacion;
public class TramiteRepositorio (DataContext db) : ITramiteRepositorio
{
 public Tramite getTRAMporID(int idTram)
    {
        Tramite? t2 = db.Tramites.FirstOrDefault(t => t.Id == idTram);
        
        if (t2 != null)
        {
            return t2;
        }
        throw new Exception("Tramite con ID " + idTram + " no encontrado");
    }


    public void agregarTramite(Tramite tram)
    {
        DateTime ahora= DateTime.Now;
        tram.creacion= ahora;
        tram.modificacion= ahora;
        db.Tramites.Add(tram);
        db.SaveChanges(); 
    }

    public void modificarTramite(Tramite tram, int idUser, string cont)
    {
        if (tram != null)
        {
             tram.contenido = cont; 
             tram.idUltimoUser= idUser;
             tram.modificacion= DateTime.Now;
        }
        else
            throw new RepositorioException();
        db.SaveChanges();
    }
    
    public void bajaTramite(int idTram)
    {
        using var db = new DataContext();
        var TramiteBorrar = db.Tramites.FirstOrDefault(a => a.Id == idTram);
        if (TramiteBorrar != null)
        {
            db.Remove(TramiteBorrar); 
        }
        else
            throw new RepositorioException();
        db.SaveChanges(); 
    }

    public List<Tramite> consultaPorEtiqueta(string etiqueta)

    {
        if (string.IsNullOrWhiteSpace(etiqueta))
    {
        return db.Tramites.ToList();
    }
        var tramites = db.Tramites
                    .Where(t => t.etiqueta == etiqueta)
                    .ToList();
        return tramites;
    }

public List<Tramite> consultaPorIdExp(int idExp)
{
    var tramites = db.Tramites
                    .Where(t => t.expedienteId == idExp)
                    .ToList();
    return tramites;
}
}
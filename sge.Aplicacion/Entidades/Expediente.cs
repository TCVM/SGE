namespace sge.Aplicacion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Expediente
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set;}
    public string caratula { get; set;}
    public DateTime fechaCreacion { get; set; }
    public DateTime fechaUltimaModificacion { get; set; }
    public int idUsuario { get; set;}   // ultima modificacion
    public string estado { get; set; }
    //public List<Tramite> tramites;
  
    public Expediente()
    {
        estado="";
        caratula="";
    }
}
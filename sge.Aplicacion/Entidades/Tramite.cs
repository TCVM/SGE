namespace sge.Aplicacion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Tramite
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int expedienteId { get; set;}
    public string etiqueta { get; set;}
    public DateTime creacion{ get; set; }
    public DateTime modificacion { get; set;}
    public int idUltimoUser{ get; set; }

    public string contenido{ get; set; }

    public Tramite() 
    {
        contenido="";
        etiqueta="";
    }

}
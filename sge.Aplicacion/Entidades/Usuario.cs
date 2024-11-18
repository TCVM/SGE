namespace sge.Aplicacion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; } 
        public string Mail { get; set; } 
        public string Password { get; set; }
        public string Perm { get; set; }
        public bool Admin {get;set;} = false;
    
        public Usuario(){
            Password="";
            Mail="";
            Nombre="";
            Apellido="";
            Perm="";
        }
    }



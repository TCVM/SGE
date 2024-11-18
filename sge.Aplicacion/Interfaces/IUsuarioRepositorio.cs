namespace sge.Aplicacion;

public interface IUsuarioRepositorio
{
  public Usuario agregarUsuario(Usuario usuario);
  List<Usuario> listarUsuarios();  
  Usuario? buscarUsuario(int IdUser); 
  public bool conseguirDatos(string email, string contra);
  Usuario? buscarUsuarioPorMail(string email); 
  void ModificarUsuario(Usuario usuario);   
  void EliminarUsuario(int id); 
}
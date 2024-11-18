namespace sge.Repositorios;
using sge.Aplicacion;
  public class DatabaseSqlite
  {
    public static void Inicializar()
    {
      using var context = new DataContext();

      context.Database.EnsureDeleted();

      if (context.Database.EnsureCreated())
      {
        Console.WriteLine("Se creo la base de datos");
      }
    }
  }
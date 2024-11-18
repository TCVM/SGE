using Microsoft.EntityFrameworkCore;
using sge.Aplicacion;
using sge.Repositorios;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using SGE.UI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configurar el context de base de datos
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlite("Data Source=database.sqlite"));

//Inyeccion de dependencias 
builder.Services.AddScoped<IExpedienteRepositorio, ExpedienteRepositorio>();
builder.Services.AddScoped<ITramiteRepositorio, TramiteRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IServicioAutorizacion, ServicioAutorizacion>(); 
builder.Services.AddScoped<TramiteValidador>(); 
builder.Services.AddScoped<ExpedienteValidador>();  
builder.Services.AddScoped<UsuarioValidador>();  
builder.Services.AddScoped<ServicioActualizacionEstado>();
// Usuarios
builder.Services.AddScoped<CasoDeUsoUsuarioAlta>();
builder.Services.AddScoped<CasoDeUsoUsuarioBaja>();
builder.Services.AddScoped<CasoDeUsoUsuarioModificar>();
builder.Services.AddScoped<CasoDeUsoUsuarioBuscarPorUsuario>();
builder.Services.AddScoped<CasoDeUsoUsuarioBuscarPorMailYPass>();
builder.Services.AddScoped<CasoDeUsoUsuarioBuscarPorMail>();
builder.Services.AddScoped<CasoDeUsoIniciarSesion>();
builder.Services.AddScoped<CasoDeUsoUsuarioListar>();
// Expedientes
builder.Services.AddScoped<CasoDeUsoExpedienteAlta>();
builder.Services.AddScoped<CasoDeUsoExpedienteBaja>();
builder.Services.AddScoped<CasoDeUsoExpedienteModificacion>();
builder.Services.AddScoped<CasoDeUsoExpedienteConsultaPorId>();
builder.Services.AddScoped<CasoDeUsoExpedienteConsultaTodos>();
// Tramites
builder.Services.AddScoped<CasoDeUsoTramiteAlta>();
builder.Services.AddScoped<CasoDeUsoTramiteBaja>();
builder.Services.AddScoped<CasoDeUsoTramiteConsultaPorEtiqueta>();
builder.Services.AddScoped<CasoDeUsoTramiteModificacion>();

builder.Services.AddSingleton<UsuarioServicioLogin>();

var app = builder.Build();

//inicializar base de datos
DatabaseSqlite.Inicializar();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
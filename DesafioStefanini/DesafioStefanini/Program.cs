using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DesafioStefanini.Data;
using DesafioStefanini.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DesafioStefaniniContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DesafioStefaniniContext") ?? throw new InvalidOperationException("Connection string 'DesafioStefaniniContext' not found.")));

// register services
//seed
builder.Services.AddScoped<SeedingService>();
//pedidos
builder.Services.AddScoped<PedidosService>();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
    var seedingService = app.Services.CreateScope()
        .ServiceProvider.GetRequiredService<SeedingService>();
    seedingService.Seed();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

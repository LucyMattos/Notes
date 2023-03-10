using BlocodeNotasApi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<NotesContext>(options =>
    {
        options.EnableSensitiveDataLogging(true);
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), opt =>
        {

            opt.MigrationsAssembly("BlocodeNotasApi");
            opt.MigrationsHistoryTable("Migrations", "Configuration");
        });
    }, ServiceLifetime.Transient);


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

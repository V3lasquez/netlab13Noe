using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using netlab13Noe.Data;
using netlab13Noe.Models;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<netlab13NoeContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("netlab13NoeContext") ?? throw new InvalidOperationException("Connection string 'netlab13NoeContext' not found.")));

// Add services to the container.
builder.Services.AddDbContext<ValuesController>();


builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
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

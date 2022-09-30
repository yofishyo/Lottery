using Lottery.Entities.Models;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DB �s�u
builder.Services.AddDbContext<LotteryDbContext>(options =>
options.UseSqlServer(
                  builder.Configuration.GetConnectionString("DefaultConnection"),
                  //Migrations���M�צ�m
                  b => b.MigrationsAssembly("Lottery.Entities")));

#region �`�UDB
builder.Services.AddTransient<LotteryDbContext>();
#endregion
#region �`�Uservice
//builder.Services.AddScoped<ICategoryService, CategoryService>();
#endregion

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

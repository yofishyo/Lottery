using Lottery.Entities.Models;
using Lottery.Services.Services;

using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
#region ���Uswagger�B�����]�w
//�]�w�Ա��Ѿ\�Ghttps://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "����t��API",
        Description = "��������ϥ�",
        Version = "v1"
    });
    // �[�Jxml�ɮר�swagger
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});
#endregion

//DB �s�u
builder.Services.AddDbContext<LotteryDbContext>(options =>
options.UseSqlServer(
                  builder.Configuration.GetConnectionString("DefaultConnection"),
                  //Migrations���M�צ�m
                  b => b.MigrationsAssembly("Lottery.Entities")));

#region �`�JDB
//builder.Services.AddTransient<LotteryDbContext>();
#endregion
#region �`�Jservice
builder.Services.AddScoped<ISampleService, SampleService>();
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

//Exception Handling
app.UseExceptionHandler(c => c.Run(async context =>
{
    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
    var exception = exceptionHandlerPathFeature.Error;

    await context.Response.WriteAsJsonAsync(new { error = exception.Message });
}));


app.MapControllers();

app.Run();

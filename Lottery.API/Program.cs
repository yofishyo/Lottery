using Lottery.Entities.Models;
using Lottery.Services.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "抽獎系統API",
        Description = "尾牙抽獎使用",
        Version = "v1"
    });
    // 加入xml檔案到swagger
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});
     
//DB 連線
builder.Services.AddDbContext<LotteryDbContext>(options =>
options.UseSqlServer(
                  builder.Configuration.GetConnectionString("DefaultConnection"),
                  //Migrations的專案位置
                  b => b.MigrationsAssembly("Lottery.Entities")));

#region 注冊DB
builder.Services.AddTransient<LotteryDbContext>();
#endregion
#region 注冊service
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

app.MapControllers();

app.Run();

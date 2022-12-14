using Lottery.Entities.Models;
using Lottery.Services.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
#region 註冊swagger、相關設定
//設定詳情參閱：https://aka.ms/aspnetcore/swashbuckle
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
#endregion

//DB 連線
builder.Services.AddDbContext<LotteryDbContext>(options =>
options.UseSqlServer(
                  builder.Configuration.GetConnectionString("DefaultConnection"),
                  //Migrations的專案位置
                  b => b.MigrationsAssembly("Lottery.Entities")));

#region 注入DB
builder.Services.AddTransient<LotteryDbContext>();
#endregion
#region 注入service
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

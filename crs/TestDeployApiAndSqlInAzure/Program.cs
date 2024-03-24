using DeployApiAndSqlInAzure.DbContexts.Extensions;
using TestDeployApiAndSqlInAzure.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("AzureSql");

builder.Services.AddSqlServer<WeatherDbContext>(connectionString);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MigrateDbContext<WeatherDbContext>();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

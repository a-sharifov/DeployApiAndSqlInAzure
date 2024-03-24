using DeployApiAndSqlInAzure.Controllers.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDeployApiAndSqlInAzure.DbContexts;
using TestDeployApiAndSqlInAzure.Models;

namespace TestDeployApiAndSqlInAzure.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(WeatherDbContext weatherDbContext) : ControllerBase
{
    private readonly WeatherDbContext _weatherDbContext = weatherDbContext;

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get() => 
        await _weatherDbContext.WeatherForecasts.ToListAsync();

    [HttpGet("{id}")]
    public async Task<WeatherForecast> Get(int id) => 
        await _weatherDbContext.WeatherForecasts.FirstAsync(x => x.Id == id);

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PostRequest request)
    {
        var weatherForecast = new WeatherForecast(request.Date, request.TemperatureC, request.Summary);
        await _weatherDbContext.AddAsync(weatherForecast);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _weatherDbContext.WeatherForecasts.Where(x => x.Id == id).ExecuteDeleteAsync();
        return Ok();
    }
}

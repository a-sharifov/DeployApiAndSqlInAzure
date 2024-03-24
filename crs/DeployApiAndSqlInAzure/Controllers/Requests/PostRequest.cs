namespace DeployApiAndSqlInAzure.Controllers.Requests;

public record PostRequest(
    DateOnly Date, 
    int TemperatureC, 
    string? Summary);

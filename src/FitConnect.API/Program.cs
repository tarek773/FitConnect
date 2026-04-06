using Scalar.AspNetCore; // ضفنا السطر ده فوق

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi(); // خدمة الـ OpenAPI

var app = builder.Build();

// ده السطر اللي بيخلي الـ API يوصف نفسه (JSON)
app.MapOpenApi();

// ده السطر اللي بيفتح لك واجهة تجربة الـ API (Scalar)
// هتفتح من اللينك ده: http://localhost:5000/scalar/v1
app.MapScalarApiReference();

// وقفنا الـ Https عشان الدوكر
// app.UseHttpsRedirection(); 

var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        )).ToArray();
    return forecast;
}).WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.MapGet("/", () => $"<p>Hello World! Current time is {DateTime.Now.ToString("hh:mm tt")}</p>");
app.MapPost("/", () => $"<p>Hello World, this is a Post request.Current time is {DateTime.Now.ToString("hh:mm tt")}</p>");

app.MapGet("/name/{aName}", (string aName) =>
{
    if(DateTime.Now.Hour < 12) return $"<p>Good Morning {aName}, this is a GET request. Current time is {DateTime.Now.ToString("hh:mm tt")}</p>";
    else if (DateTime.Now.Hour < 18) return $"<p>Good Afternoon {aName}, this is a GET request. Current time is {DateTime.Now.ToString("hh:mm tt")}</p>";
    
    return $"<p>Good evening {aName}, this is a GET request. Current time is {DateTime.Now.ToString("hh:mm tt")}</p>";
});

app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World from " + builder.Configuration["DisplayEnvironment"]);
app.MapGet("/", () => "Deployment triggered from " + builder.Configuration["DisplaySourceEnvironment"])  + builder.Configuration["DisplayTargetEnvironment"]);

app.Run();

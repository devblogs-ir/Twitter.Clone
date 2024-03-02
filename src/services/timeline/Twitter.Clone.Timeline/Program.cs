

using Twitter.Clone.Timeline.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerService();

var app = builder.Build();

app.UseSwaggerApp();

app.UseHttpsRedirection();
app.Run();


 
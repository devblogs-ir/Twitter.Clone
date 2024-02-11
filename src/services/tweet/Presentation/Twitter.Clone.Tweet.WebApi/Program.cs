using Twitter.Clone.Tweet.Infrastructure.Persistence.DbContext;
using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Tweet.WebApi.Model;

var builder = WebApplication.CreateBuilder(args);

// Get Settings from appsettings.json
var _mongoDbConfigurations = new MongoDbConfigurationModel();
builder.Configuration.GetSection("MongoDbConfiguration").Bind(_mongoDbConfigurations);  

// Add services to the container. 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TweetDbContext>(options => options.UseMongoDB(
        connectionString: _mongoDbConfigurations.ConnectionString ?? "mongodb://localhost:27017", 
        databaseName: _mongoDbConfigurations.DatabaseName ?? "TweetDb"
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
 
app.MapGet("/tweet", () =>
{
    Console.WriteLine("Test");
}) 
.WithOpenApi();
app.Run();

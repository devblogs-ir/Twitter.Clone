var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    // Todo
}) 
.WithOpenApi();

app.Run();

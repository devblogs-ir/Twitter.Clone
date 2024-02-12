using Twitter.Clone.Search.Application;
using Twitter.Clone.Search.Infrastracture;
using Twitter.Clone.Search.Presentation;

var builder = WebApplication.CreateBuilder(args);


builder.Services.RegisterApplicationServices()
                .RegisterInfrastructureServices()
                .RegisterPresentationServices();

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


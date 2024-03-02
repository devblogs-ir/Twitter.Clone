namespace Twitter.Clone.Timeline.Extensions
{
    public static class WebApplicationExtension
    {
        public static void UseSwaggerApp(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(
                    options =>
                    {
                        options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
                    });
            }
        }
    }
}

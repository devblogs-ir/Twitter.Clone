

namespace Twitter.Clone.Timeline.Extensions
{
    public static class ServiceCollectionExtension
    {
         
        public static IServiceCollection AddSwaggerService(this IServiceCollection services)
        {
          return services.AddSwaggerGen(opt => { });
        }
    }
}

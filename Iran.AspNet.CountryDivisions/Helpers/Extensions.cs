using Iran.AspNet.CountryDivisions;
using Microsoft.Extensions.DependencyInjection;

namespace Iran.AspNet.CountryDivisions.Helpers
{
    public static class Extensions
    {
        public static IServiceCollection AddIranCountryDivisions(this IServiceCollection services)
        {
            return services.AddScoped<IIranCountryDivisions, IranCountryDivisions>();

        }
    }
}

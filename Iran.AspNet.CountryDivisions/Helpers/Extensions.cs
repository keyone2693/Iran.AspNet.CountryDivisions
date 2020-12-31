using Iran.AspNet.CountryDivisions.Data.DatabaseContext;
using Microsoft.Extensions.DependencyInjection;

namespace Iran.AspNet.CountryDivisions.Helpers
{
    public static class Extensions
    {
        public static void AddIranCountryDivisions(this IServiceCollection services)
        {
            services.AddDbContext<LocationsDbContext>();
            services.AddScoped<IIranCountryDivisions, IranCountryDivisions>();
        }
    }
}

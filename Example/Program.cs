using System;

using Iran.AspNet.CountryDivisions;
using Iran.AspNet.CountryDivisions.Data.DatabaseContext;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var _iranCountryDivisions =
        new IranCountryDivisions(new LocationsDbContext());
            _iranCountryDivisions.UpdateDatabaseAsync().GetAwaiter();

            Console.WriteLine("Hello World!");
        }
    }
}

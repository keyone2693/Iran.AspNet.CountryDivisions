
![Divisions of Iran](/screen.png)

# Iran.AspNet.CountryDivisions
&#x202b;
پکیج C# و ASP
&#x202b;
برای دریافت و جستوجوی 
کشور ها و

استان ها ، شهر ها ،بخش ها ،دهستان ها و روستاهای ایران
&#x202b;
و استفاده در Select ها  ، DropDown لیست ها و همچنین درخواست های Api  

## Development 



[![Build status](https://img.shields.io/appveyor/ci/keyone2693/imageresizer-aspnetcore.svg)](https://ci.appveyor.com/project/keyone2693/iran-aspnet-countrydivisions)
[![NuGet](https://img.shields.io/nuget/v/Iran.AspNet.CountryDivisions.svg)](https://www.nuget.org/packages/Iran.AspNet.CountryDivisions/)
[![GitHub issues](https://img.shields.io/github/issues/keyone2693/Iran.AspNet.CountryDivisions.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/Iran.AspNet.CountryDivisions/issues)
[![GitHub stars](https://img.shields.io/github/stars/keyone2693/Iran.AspNet.CountryDivisions.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/Iran.AspNet.CountryDivisions/stargazers)
[![GitHub license](https://img.shields.io/github/license/keyone2693/Iran.AspNet.CountryDivisions.svg?maxAge=25920?style=plastic)](https://github.com/keyone2693/Iran.AspNet.CountryDivisions/blob/master/LICENSE)


### Json Files: [files](https://github.com/keyone2693/Iran.AspNet.CountryDivisions/tree/master/Iran.AspNet.CountryDivisions/Data)


#### Current version: 2.1.x [Stable]

| استان (ایران) | شهرستان (ایران) | بخش (ایران) | شهر (ایران) | دهستان (ایران) | آبادی (ایران) | کشور |
| --- | --- | --- | --- | --- | --- | --- |
| ۳۱ | ۴۴۸ | ۱۰۹۹ | ۱۵۵۴/۱۳۵۴ | ۲۶۳۷ | ۹۸۱۰۰ | 269 |


In this version:
you can get all IRANS provinces, cities, districts, counties, towns and villages


or search for them


Also its includes countries list with their iso , domain , enName , faName , fips


--- there is no relation between tables



##
.net standard 2.0

## Easy to install
Use the library as dll, reference from [nuget](https://www.nuget.org/packages/Iran.AspNet.CountryDivisions/)
or use this in your package manager console
```c#
Install-Package Iran.AspNet.CountryDivisions
```


# Wiki

you only need to add two things

... Recomended ...
```c#
//Startup.cs
public void ConfigureServices(IServiceCollection services)
{
  //...
  services.AddIranCountryDivisions();
}
```
```c#
//Controller
private readonly IIranCountryDivisions _iranCountryDivisions;
public TestController(IIranCountryDivisions iranCountryDivisions)
{
  _iranCountryDivisions = iranCountryDivisions;
}
```

or :
```c#
  //...
  IIranCountryDivisions _iranCountryDivisions = new IranCountryDivisions(new Iran.AspNet.CountryDivisions.Data.DatabaseContext.LocationsDbContext());
  //...
```

then you can use it like this :

(تمام شهر ها داخل جدول شهرستان ها میباشد ، پس بهتر است همیشه با جدول شهرستان ها به عنوان لیست کامل شهر ها کار بکنید )

```c#
  //...
  var allOstans = await _iranCountryDivisions.GetOstansAsync();
  var ostansWithSearchAndOrderByAndCount = await _iranCountryDivisions.GetOstansAsync(p => p.Name.Contains(nameSearch), o=>o.OrderBy(p=>p.Name) , 10);
  
  
  var allAbadis = await _iranCountryDivisions.GetAbadisAsync();
  var abadisWithSearch = await _iranCountryDivisions.GetAbadisAsync(p => p.ShahrestanId == shahrId &&  p.Name.Contains(nameSearch));
  
  //...
```
same for others


## Special thanks

[Ahmad Azizi](https://github.com/ahmadazizi) and his [IRAN database](https://github.com/ahmadazizi/iran-cities/)

[sh4rifi](https://github.com/sh4rifi) and his [COUNTRIES database](https://github.com/sh4rifi/countries-db)

the package will be updated base on their databases


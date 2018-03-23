# Mobiam EF101
* Entity Framework 6.*
> https://msdn.microsoft.com/en-us/library/gg696172(v=vs.103).aspx
* CodeFirst with Migrations
* Generic Repository with Unit Of Work Pattern

## Project structure 
* EF101 - ASP.Net MVC Web application
* EF101.Model - Model Class Library Project
* EF101.DAL - Data Access Layer Class Library Project

## I Setup Model Class Library Project
Create POCO for Movie
```
public class Movie
{
    public int ID { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Genre { get; set; }
    public decimal Price { get; set; }
}
```

## II Setup DAL Class Library Project
1. Add EF 6.* via Nuget repo to EF101.DAL

2. Configure Connection String 
> https://msdn.microsoft.com/en-us/library/jj556606(v=vs.113).aspx

**Important: add connection string to libs app.config and startup project web.config**

```
<connectionStrings> 
  <add name="EF101DBContext"  
        providerName="System.Data.SqlClient"  
        connectionString="Server={server};Database={database};Persist Security Info=False;
			User ID={your_username};Password={your_password};MultipleActiveResultSets=False;
			Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"/> 
</connectionStrings>
```

3. enable-migrations (from Package Manager Console)

4. Implement DbContext (EF101DBContext)
```
public class EF101DBContext : DbContext
    {
        public EF101DBContext() 
            : base("name=EF101DBContext")
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
```

5. add-migration initial

6. Configure Entity Model
* DataAnnotations
* ModelConfiguration - Fluent API

add-migration initial -force
# Mobiam EF101
# Entity Framework 6.*
# CodeFirst with Migrations
# Generic Repository with Unit Of Work Pattern

## Project structure 
* EF101 - ASP.Net MVC Web application
* EF101.Model - Library for model classes (POCO)
* EF101.DAL - Data Access Layer

1. Add EF 6.* via Nuget repo to EF101.DAL
2. Configure Connection String https://msdn.microsoft.com/en-us/library/jj556606(v=vs.113).aspx
```
<connectionStrings> 
  <add name="BlogContext"  
        providerName="System.Data.SqlClient"  
        connectionString="Server=.\SQLEXPRESS;Database=Blogging;Integrated Security=True;"/> 
</connectionStrings>
```
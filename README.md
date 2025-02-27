## C# BackEnd :O
by @trevisharp

### Entity Framework Demo 

Dependencies and packages commands:

```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

### AspNet Demo 

Dependencies and packages commands:

```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Swashbuckle.AspNetCore
dotnet tools install dotnet-ef
dotnet tools update dotnet-ef
```

Working with Migrations:
```
dotnet ef migrations add (migration_name)
dotnet ef update database
```


### TemplaerArchDemo

Made using the [Clean.Architecture.Solution.Template](https://github.com/jasontaylordev/CleanArchitecture) version 9.0.8.

Like to have it here to i can look up easily where everything goes when studying and developing a Clean Architecture on my own 

### CleanArchDemo

My (first) attempt on Clean Architecture. Might be a little messy :p
A To-Do-List as simple as can be so the ocmplex stays only in the arch and folders hihi

#### Commands used (for future studies and recaps):


Starting the application:

```
dotnet new webapi
```

Dependencies:

```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Swashbuckle.AspNetCore
```
### Questions for later:

- [ ] where should interfaces of repositories go? Application or Domain?
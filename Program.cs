using Exemple.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddDbContext<ExempleDBContext>(options => {

    // options.UseInMemoryDatabase("my-inmemory-dataabse"); \\ for in memory databases 

    var connBuilder = new SqlConnectionStringBuilder{
        TrustServerCertificate = true,
        IntegratedSecurity = true,
        DataSource = "localhost",
        InitialCatalog = "MyExampleDatabase"
    };
    options.UseSqlServer(connBuilder.ConnectionString);
});

var provider = services.BuildServiceProvider(); 

var scope = provider.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ExempleDBContext>();

context.Database.EnsureCreated();

var obj = new EntityA{
    Name = "jr"
};

var obj1 = new EntityA{
    Name = "jr jr"
};
context.Add(obj);
context.SaveChanges();

context.Remove(obj);
await context.SaveChangesAsync();

foreach (var item in context.EntitiesAs)
{
    Console.WriteLine(item.Name);
}
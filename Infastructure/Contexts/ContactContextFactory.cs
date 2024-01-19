using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Contexts;

public class ContactContextFactory : IDesignTimeDbContextFactory<ContactContext>
{
    public ContactContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ContactContext>();
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anna\Documents\Repos\SQLConsoleApplication\Infastructure\Data\Contact_database.mdf;Integrated Security=True;Connect Timeout=30");
    
        return new ContactContext(optionsBuilder.Options);
    }
}

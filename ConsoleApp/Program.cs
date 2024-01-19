using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shared.Context;
using Shared.Repositories;
using Shared.Services;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<ContactContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anna\Documents\Repos\SQLConsoleApplication\Shared\Data\Contact_Database.mdf;Integrated Security=True;Connect Timeout=30"));

    services.AddScoped<ContactRepository>();
    services.AddScoped<AddressRepository>();
    services.AddScoped<PhoneNumberRepository>();
    services.AddScoped<ContactService>();

}).Build();
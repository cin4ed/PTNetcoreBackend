using Microsoft.EntityFrameworkCore;
using PTNetcoreBackend.Models;

namespace PTNetcoreBackend.Data;

public class DatabaseContext : DbContext
{
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<PTNetcoreBackend.Models.Contact> Contact { get; set; }
}
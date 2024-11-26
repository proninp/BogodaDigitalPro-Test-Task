using ContactsBook.Core.Models;
using ContactsBook.Core.Options;
using ContactsBook.Core.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ContactsBook.Data.Data;
public class AppDbContext : DbContext, IUnitOfWork
{
    private readonly AppSettings _options;

    public AppDbContext(IOptionsSnapshot<AppSettings> options)
    {
        _options = options.Value;
    }

    public required DbSet<Contact> Contacts { get; set; }

    public async Task<int> Commit(CancellationToken cancellationToken = default)
    {
        return await SaveChangesAsync(cancellationToken);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(_options.DbConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}

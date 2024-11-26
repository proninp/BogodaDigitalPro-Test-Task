using ContactsBook.Core.Models;
using ContactsBook.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactsBook.Data.Data.Configurations;
public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasData(DataSeeder.GetContactsSeeding());
    }
}

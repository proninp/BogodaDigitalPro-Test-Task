using ContactsBook.Core.Models.Abstractions;

namespace ContactsBook.Core.Models;
public class Contact : BaseModel
{
    public required string PhoneNumber { get; set; }

    public required string FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? Company { get; set; }

    public string? Position { get; set; }

    public string? Notes { get; set; }
}

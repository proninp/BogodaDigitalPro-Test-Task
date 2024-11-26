using ContactsBook.Core.Models;

namespace ContactsBook.Core.DataTransferObjects.ViewModels;
public class ContactDto
{
    public Guid Id { get; init; }

    public required string PhoneNumber { get; init; }

    public required string FirstName { get; init; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? Company { get; set; }

    public string? Position { get; set; }

    public string? Notes { get; set; }
}

public static class ContactMappings
{
    public static ContactDto ToDto(this Contact contact)
    {
        return new ContactDto
        {
            Id = contact.Id,
            PhoneNumber = contact.PhoneNumber,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            Email = contact.Email,
            DateOfBirth = contact.DateOfBirth,
            Address = contact.Address,
            Company = contact.Company,
            Position = contact.Position,
            Notes = contact.Notes,
        };
    }
}
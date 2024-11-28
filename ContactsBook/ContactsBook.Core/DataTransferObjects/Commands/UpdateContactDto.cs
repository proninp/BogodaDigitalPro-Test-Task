using ContactsBook.Core.DataTransferObjects.Abstractions;
using ContactsBook.Core.Models;

namespace ContactsBook.Core.DataTransferObjects.Commands;
public class UpdateContactDto : BaseDto, IUpdateDto<Contact>
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

    public Contact ToModel()
    {
        return new Contact
        {
            PhoneNumber = PhoneNumber, 
            FirstName = FirstName,
            LastName = LastName,
            Email = Email,
            DateOfBirth = DateOfBirth,
            Address = Address,
            Company = Company,
            Position = Position,
            Notes = Notes
        };
    }
}

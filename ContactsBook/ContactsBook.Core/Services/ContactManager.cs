using ContactsBook.Core.DataTransferObjects.Commands;
using ContactsBook.Core.DataTransferObjects.ViewModels;
using ContactsBook.Core.Models;
using ContactsBook.Core.Services.Abstractions;

namespace ContactsBook.Core.Services;
public class ContactManager : BaseManager<Contact, PutContactDto>, IContactManager
{
    public ContactManager(IRepository<Contact> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }

    public async Task<ContactDto?> GetById(Guid id)
    {
        return (await _repository.GetById(id))?.ToDto();
    }

    public async Task<ContactDto[]> GetByName(string firstname)
    {
        return await _repository.Get(c => c.FirstName.Contains(firstname), c => c.ToDto());
    }

    public async Task<ContactDto[]> GetByPhone(string phone)
    {
        return await _repository.Get(c => c.PhoneNumber.Contains(phone), c => c.ToDto());
    }

    protected override void Update(Contact model, PutContactDto command)
    {
        model.PhoneNumber = command.PhoneNumber;
        model.FirstName = command.FirstName;
        model.LastName = command.LastName;
        model.Email = command.Email;
        model.DateOfBirth = command.DateOfBirth;
        model.Address = command.Address;
        model.Company = command.Company;
        model.Position = command.Position;
        model.Notes = command.Notes;
    }
}

using ContactsBook.Core.DataTransferObjects.Commands;
using ContactsBook.Core.DataTransferObjects.ViewModels;
using ContactsBook.Core.Models;
using ContactsBook.Core.Services.Abstractions;

namespace ContactsBook.Core.Services;
public class ContactManager : BaseManager<Contact, ContactDto, CreateContactDto, UpdateContactDto>, IContactManager
{
    public ContactManager(IRepository<Contact> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }

    public ContactDto[] Get()
    {
        return _repository.Get(c => true, c => c.ToDto());
    }

    public async Task<ContactDto?> GetById(Guid id)
    {
        return (await _repository.GetById(id))?.ToDto();
    }

    public ContactDto[] GetByName(string firstname)
    {
        return _repository.Get(c => c.FirstName.Contains(firstname), c => c.ToDto());
    }

    public ContactDto[] GetByPhone(string phone)
    {
        return _repository.Get(c => c.PhoneNumber.Contains(phone), c => c.ToDto());
    }

    protected override ContactDto GetViewNodel(Contact model)
    {
        return model.ToDto();
    }

    protected override void UpdateModel(Contact model, UpdateContactDto command)
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

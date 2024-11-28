using ContactsBook.Core.DataTransferObjects.Commands;
using ContactsBook.Core.DataTransferObjects.ViewModels;

namespace ContactsBook.Core.Services.Abstractions;
public interface IContactManager
{
    public ContactDto[] Get();

    public Task<ContactDto?> GetById(Guid id);

    public ContactDto[] GetByName(string firstname);

    public ContactDto[] GetByPhone(string phone);

    public Task Create(CreateContactDto command);

    public Task Update(UpdateContactDto command);

    public Task Delete(Guid id);
}
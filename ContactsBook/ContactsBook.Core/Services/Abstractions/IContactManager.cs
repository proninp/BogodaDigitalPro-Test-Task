using ContactsBook.Core.DataTransferObjects.Commands;
using ContactsBook.Core.DataTransferObjects.ViewModels;

namespace ContactsBook.Core.Services.Abstractions;
public interface IContactManager
{
    public Task<ContactDto?> GetById(Guid id);

    public Task<ContactDto[]> GetByName(string firstname);

    public Task<ContactDto[]> GetByPhone(string phone);

    public Task Put(PutContactDto command);

    public Task Delete(Guid id);
}
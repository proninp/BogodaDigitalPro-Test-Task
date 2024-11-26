using ContactsBook.Core.Models.Abstractions;

namespace ContactsBook.Core.DataTransferObjects.Commands.Abstractions;
public abstract class BasePutDto<T> where T : BaseModel
{
    public Guid? Id { get; init; }

    public abstract T ToModel();
}
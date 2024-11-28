using ContactsBook.Core.Models.Abstractions;

namespace ContactsBook.Core.DataTransferObjects.Abstractions;
public interface IUpdateDto<T>
    where T : BaseModel
{
    public abstract T ToModel();
}
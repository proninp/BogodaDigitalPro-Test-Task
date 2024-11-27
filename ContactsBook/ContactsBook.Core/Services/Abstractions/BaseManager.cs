using ContactsBook.Core.DataTransferObjects.Commands.Abstractions;
using ContactsBook.Core.Exceptions;
using ContactsBook.Core.Models.Abstractions;

namespace ContactsBook.Core.Services.Abstractions;
public abstract class BaseManager<T, TDto>
    where T : BaseModel
    where TDto : BasePutDto<T>
{
    protected readonly IRepository<T> _repository;
    protected readonly IUnitOfWork _unitOfWork;

    public BaseManager(IRepository<T> repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public virtual async Task Put(TDto command)
    {
        if (command.Id is null)
        {
            _repository.Add(command.ToModel());
        }
        else
        {
            var entity = await GetEntityById(command.Id.Value);
            Update(entity, command);
        }
        await _unitOfWork.Commit();
    }

    public async Task Delete(Guid id)
    {
        var entry = await GetEntityById(id);
        _repository.Delete(entry);
        await _unitOfWork.Commit();
    }

    protected async Task<T> GetEntityById(Guid id)
    {
        var entry = await _repository.GetById(id);
        if (entry is null)
            throw new EntityNotFoundException($"The record '{typeof(T).Name}' with id:'{id}' was not found.");
        return entry;
    }

    protected abstract void Update(T model, TDto command);
}

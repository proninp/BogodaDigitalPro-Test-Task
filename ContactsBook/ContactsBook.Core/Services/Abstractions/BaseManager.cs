﻿using ContactsBook.Core.DataTransferObjects.Abstractions;
using ContactsBook.Core.Exceptions;
using ContactsBook.Core.Models.Abstractions;

namespace ContactsBook.Core.Services.Abstractions;
public abstract class BaseManager<T, TViewDto, TCreateDto, TUpdateDto>
    where T : BaseModel
    where TViewDto : BaseDto
    where TUpdateDto : BaseDto, IUpdateDto<T>
    where TCreateDto : IUpdateDto<T>
{
    protected readonly IRepository<T> _repository;
    protected readonly IUnitOfWork _unitOfWork;

    public BaseManager(IRepository<T> repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<TViewDto> Create(TCreateDto command)
    {
        var model = _repository.Add(command.ToModel());
        await _unitOfWork.Commit();
        return GetViewNodel(model);
    }

    public virtual async Task Update(TUpdateDto command)
    {
        var entity = await GetEntityById(command.Id);
        UpdateModel(entity, command);
        _repository.Update(entity);
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

    protected abstract void UpdateModel(T model, TUpdateDto command);

    protected abstract TViewDto GetViewNodel(T model);
}

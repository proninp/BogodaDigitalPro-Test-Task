﻿using ContactsBook.Core.Models.Abstractions;

namespace ContactsBook.Core.Services.Abstractions;
public interface IRepository<T> where T : BaseModel
{
    Task<T?> GetById(Guid id);

    Task<TResult[]> Get<TResult>(Func<T, bool> predicate, Func<T, TResult> selector);

    void Add(T item);

    void Update(T item);

    void Delete(T item);

    Task Delete(Guid id);
}

using ContactsBook.Core.Models.Abstractions;
using ContactsBook.Core.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ContactsBook.Data.Data.Repositories;
public class Repository<T> : IRepository<T> where T : BaseModel
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<T?> GetById(Guid id)
    {
        return await _context
            .Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<TResult[]> Get<TResult>(Func<T, bool> predicate, Func<T, TResult> selector)
    {
        return await _context
            .Set<T>()
            .Where(x => predicate(x))
            .AsNoTracking()
            .Select(x => selector(x))
            .ToArrayAsync();
    }

    public void Add(T item)
    {
        _context.Add(item);
    }

    public void Update(T item)
    {
        _context.Set<T>().Update(item);
    }

    public void Delete(T item)
    {
        _context.Remove(item);
    }

    public async Task Delete(Guid id)
    {
        var item = await _context.Set<T>().FirstOrDefaultAsync(u => u.Id == id);
        if (item is not null)
        {
            Delete(item);
        }
    }
}

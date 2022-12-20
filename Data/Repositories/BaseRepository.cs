using System.Reflection;
using Data.Interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Webshop.GraphQl.Types.General;
using Webshop.Helpers;

namespace Data.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected AppDbContext db;

    protected IConfiguration? configuration;

    public BaseRepository(AppDbContext db, IConfiguration? configuration)
    {
        this.db = db;
        this.configuration = configuration;
    }

    async Task<T> IBaseRepository<T>.CreateAsync(T data)
    {
        if (data == null || ValidateData(data) == false)
        {
            throw new ApiException("Invalid data");
        }

        db.Add(data);
        await db.SaveChangesAsync();

        return await refetchData(data);
    }

    Task<T> IBaseRepository<T>.DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }

    async Task<PageData<T>> IBaseRepository<T>.GetAllAsync(PageRequest? pageRequest)
    {
        return new PageData<T>() { TotalCount = 0 };
    }

    Task<T> IBaseRepository<T>.GetByIdAsync(object id, bool deleted)
    {
        throw new NotImplementedException();
    }

    Task<T> IBaseRepository<T>.RestoreAsync(object id)
    {
        throw new NotImplementedException();
    }

    Task<T> IBaseRepository<T>.UpdateAsync(T data)
    {
        throw new NotImplementedException();
    }

    public virtual bool ValidateData(T data) => true;

    protected async Task<T> refetchData(T data)
    {
        db.Entry(data).State = EntityState.Detached;
        object id = getPrimaryKey(data);
        return await db.FindAsync<T>(data);
    }

    protected object getPrimaryKey(T data)
    {
        Type t = data.GetType();
        PropertyInfo prop = t.GetProperty("Id");
        return prop.GetValue(data);
    }
}
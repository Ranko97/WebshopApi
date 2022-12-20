namespace Data.Interfaces;

public interface IBaseRepository<T>
{
    Task<T> CreateAsync(T data);

    Task<T> UpdateAsync(T data);
    Task<T> DeleteAsync(object id);
    Task<T> RestoreAsync(object id);
    Task<T> GetByIdAsync(object id, bool deleted = false);
    Task<ICollection<T>> GetAllAsync();
}
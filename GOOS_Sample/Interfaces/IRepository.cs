namespace GOOS_Sample.Interfaces
{
    public interface IRepository<T>
    {
        void Save(T entity);
    }
}
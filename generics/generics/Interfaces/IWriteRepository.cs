namespace generics.Interfaces;

public interface IWriteRepository<in TEntity, in TKey> where TEntity:class, new() where TKey:struct
{
    void Add(TEntity entity);
    void Remove(TKey id);
}
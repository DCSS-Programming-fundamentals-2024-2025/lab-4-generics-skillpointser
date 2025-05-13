using generics.Interfaces;

namespace generics.Repository;

public class InMemoryRepository<TEntity,TKey> : IRepository<TEntity,TKey> , IReadOnlyRepository<TEntity, TKey>, IWriteRepository<TEntity, TKey> where TEntity:class, new() where TKey:struct
{
    private Dictionary<TKey, TEntity> _entities = [];
    public void Add(TKey id, TEntity entity)
    {
        _entities.Add(id,entity);
    }

    public TEntity Get(TKey id)
    {
        return _entities[id];
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _entities.Values;
    }

    public void Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(TKey id)
    {
        _entities.Remove(id);
    }
}
namespace generics.Interfaces;

public interface IReadOnlyRepository<out TEntity, in TKey> where TEntity:class, new() where TKey:struct
{
    TEntity Get(TKey id);
    IEnumerable<TEntity> GetAll();
}
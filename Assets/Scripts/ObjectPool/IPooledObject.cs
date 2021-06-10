public interface IPooledObject
{
    void Init();
    void OnObjectSpawn();
    void OnObjectDespawn();
    void Despawn();
    EPooledObjectType PoolType { get; set; }
}

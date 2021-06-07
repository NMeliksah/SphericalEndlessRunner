using UnityEngine;

public class PooledObject : MonoBehaviour, IPooledObject
{
    [SerializeField]
    private EPooledObjectType _type;

    public EPooledObjectType PoolType
    {
        get
        {
            return _type;
        }
        set
        {
            _type = value;
        }
    }

    public virtual void Init()
    {

    }
    public virtual void OnObjectSpawn()
    {

    }

    public virtual void OnObjectDespawn()
    {

    }

    public virtual void Despawn()
    {
        ObjectPooler.Instance.Despawn(gameObject);
    }
}
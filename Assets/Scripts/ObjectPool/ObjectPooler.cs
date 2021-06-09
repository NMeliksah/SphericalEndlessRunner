using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ObjectPooler : Singleton<ObjectPooler>
{
    public Dictionary<EPooledObjectType, Queue<GameObject>> PoolDictionary;
    public List<PoolObjects> Pool;


    private Dictionary<EPooledObjectType, int> _poolIndexes =
        new Dictionary<EPooledObjectType, int>();


    private Dictionary<EPooledObjectType, Transform> _poolMasters =
        new Dictionary<EPooledObjectType, Transform>();

    private WaitForSeconds _waitForSeconds = new WaitForSeconds(2f);

    private void Awake()
    {
        PoolDictionary = new Dictionary<EPooledObjectType, Queue<GameObject>>();

        GameObject master = new GameObject("Pool");

        for (int j = 0; j < Pool.Count; j++)
        {
            GameObject poolSpecifiMaster = new GameObject(Pool[j].Tag.ToString());
            poolSpecifiMaster.transform.SetParent(master.transform);

            Queue<GameObject> objectPool = new Queue<GameObject>();
            _poolIndexes.Add(Pool[j].Tag, j);

            _poolMasters.Add(Pool[j].Tag, poolSpecifiMaster.transform);


            for (int i = 0; i < Pool[j].Size; i++)
            {
                GameObject obj = Instantiate(Pool[j].Prefab);
                obj.transform.SetParent(poolSpecifiMaster.transform);
                if (obj.GetComponent<IPooledObject>() == null)
                {
                    PooledObject temp = obj.AddComponent<PooledObject>();
                    temp.PoolType = Pool[j].Tag;
                }
                else
                {
                    IPooledObject iPool = obj.GetComponent<IPooledObject>();
                    iPool.PoolType = Pool[j].Tag;
                }

                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            PoolDictionary.Add(Pool[j].Tag, objectPool);
        }
    }

    private void OnDestroy()
    {
        PoolDictionary = null;
        Pool = null;
        _poolIndexes = null;
        _poolMasters = null;
    }

    public GameObject SpawnFromPool(EPooledObjectType tag, Vector3 pos, Quaternion rot)
    {
        if (!PoolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("PoolObjects with Tag " + tag + " doesn't exist ..");
            return null;
        }

        GameObject objToSpawn;

        if (PoolDictionary[tag].Count != 0)
        {
            objToSpawn = PoolDictionary[tag].Peek();
            objToSpawn.SetActive(true);
            objToSpawn.transform.position = pos;
            objToSpawn.transform.rotation = rot;

            IPooledObject iPooledObj = objToSpawn.GetComponent<IPooledObject>();

            iPooledObj.Init();
            iPooledObj.OnObjectSpawn();

            PoolDictionary[tag].Dequeue();
        }
        else
        {
            objToSpawn = ExpandPool(tag, pos, rot);
        }

        return objToSpawn;
    }

    public void Despawn(GameObject obj)
    {
        DespawningOperation(obj);
    }

    private bool IsObjectImplementedRequirements(GameObject gameObject)
    {
        return gameObject.GetComponent<IPooledObject>() != null;
    }

    private void DespawningOperation(GameObject obj)
    {
        if (IsObjectImplementedRequirements(obj))
        {
            
            EPooledObjectType tag = obj.GetComponent<IPooledObject>().PoolType;
            if (!PoolDictionary[tag].Contains(obj))
            {
                PoolDictionary[tag].Enqueue(obj);


                IPooledObject iPooledObj = obj.GetComponent<IPooledObject>();
                iPooledObj?.OnObjectDespawn();

                obj.SetActive(false);
                obj.transform.SetParent(_poolMasters[tag]);
            }
            else
            {
                Debug.LogWarning("You're trying to despawn an object already despawned !");
            }
            
        }
        else
        {
            Debug.LogWarning("Object that you're trying to despawn is not pooled !");
        }
    }

    private GameObject ExpandPool(EPooledObjectType tag, Vector3 pos, Quaternion rot)
    {
        int index = _poolIndexes[tag];
        GameObject temp = Instantiate(Pool[index].Prefab);
        temp.SetActive(true);
        temp.transform.SetParent(_poolMasters[tag]);

        temp.transform.position = pos;
        temp.transform.rotation = rot;

        if (temp.GetComponent<IPooledObject>() == null)
        {
            PooledObject tempPool = temp.AddComponent<PooledObject>();
            tempPool.PoolType = tag;
        }

        IPooledObject iPooledObj = temp.GetComponent<IPooledObject>();
        iPooledObj.PoolType = tag;
        iPooledObj.Init();
        iPooledObj.OnObjectSpawn();


        PoolDictionary[tag].Enqueue(temp);
        PoolDictionary[tag].Dequeue();

        Pool[index].Size++;

        return temp;
    }
}
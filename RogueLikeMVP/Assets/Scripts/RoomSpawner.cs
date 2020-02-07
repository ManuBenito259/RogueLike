using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RoomSpawner : MonoBehaviour
{

    protected bool isSpawned;
    [SerializeField] protected RoomTemplates templates;
    
    // Start is called before the first frame update
    void Start()
    {
        isSpawned = false;
        Invoke("SpawnRoom",0.2f);
    }

    protected abstract void SpawnRoom();

    public void SetTemplate(RoomTemplates t)
    {
        templates = t;
    }

    public bool IsSpawned => isSpawned;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            Destroy(gameObject);
        }
    }
}
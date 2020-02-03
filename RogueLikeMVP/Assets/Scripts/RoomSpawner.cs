using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RoomSpawner : MonoBehaviour
{

    [SerializeField] protected RoomTemplates templates;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnRoom();
    }

    protected abstract void SpawnRoom();

    // Update is called once per frame
    void Update()
    {
        
    }
}
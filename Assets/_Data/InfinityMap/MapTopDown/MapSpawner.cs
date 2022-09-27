using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [SerializeField] protected MapCode mapCode;
    [SerializeField] protected MapInfinity currentMap;
    [SerializeField] protected MapInfinity newMapInfinity;
    [SerializeField] protected Vector3 spawnPosOffset = new Vector3(0,0,0);

    protected virtual void Awake()
    {
        this.LoadCurrentMap();
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        string objTag = other.transform.parent.tag;
        Debug.Log("other.tag: "+ objTag);
        if(objTag == "Player") this.SpawnMap();
    }

    protected virtual void SpawnMap()
    {
        if (this.MapIsSpawned()) return;

        Vector3 spawnPos = this.currentMap.transform.position;
        spawnPos.x += this.spawnPosOffset.x;
        spawnPos.y += this.spawnPosOffset.y;
        spawnPos.z += this.spawnPosOffset.z;

        GameObject newMap = Instantiate(this.currentMap.gameObject);
        newMap.transform.position = spawnPos;
        newMap.name = this.currentMap.name;
        this.newMapInfinity = newMap.GetComponent<MapInfinity>();

        //this.currentMap.Set(this.mapCode, this.newMapInfinity);
    }

    protected virtual bool MapIsSpawned()
    {
        return this.currentMap.Get(this.mapCode) != null;
    }

    protected virtual void LoadCurrentMap()
    {
        this.currentMap = transform.parent.GetComponent<MapInfinity>();
    }
}

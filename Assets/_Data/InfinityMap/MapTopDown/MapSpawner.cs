using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [SerializeField] protected MapCode mapCode;
    [SerializeField] protected MapCode mapCodeRelate;
    [SerializeField] protected MapInfinity currentMap;
    [SerializeField] protected MapInfinity newMapInfinity;
    [SerializeField] protected Vector3 spawnPosOffset = new Vector3(0,0,0);

    protected virtual void Awake()
    {
        this.LoadCurrentMap();
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        this.SpawnMap();
    }

    protected virtual void DespawnMap()
    {
        Destroy(this.newMapInfinity.gameObject);
        this.newMapInfinity = null;
        this.currentMap.Set(this.mapCode, null);
    }

    protected virtual void SpawnMap()
    {
        Vector3 spawnPos = this.currentMap.transform.position;
        spawnPos.x += this.spawnPosOffset.x;
        spawnPos.y += this.spawnPosOffset.y;
        spawnPos.z += this.spawnPosOffset.z;

        GameObject newMap = Instantiate(this.currentMap.gameObject);
        newMap.transform.position = spawnPos;
        newMap.name = newMap.name;
        this.newMapInfinity = newMap.GetComponent<MapInfinity>();


        this.currentMap.Set(this.mapCode, this.newMapInfinity);
        this.newMapInfinity.Set(this.mapCodeRelate, this.currentMap);
    }

    protected virtual void LoadCurrentMap()
    {
        this.currentMap = transform.parent.GetComponent<MapInfinity>();
    }
}

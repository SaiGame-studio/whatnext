using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChecker : MonoBehaviour
{
    [SerializeField] protected MapInfinity currentMap;
    [SerializeField] protected MapCode mapCode;
    [SerializeField] protected MapCode mapCodeRelate;

    protected virtual void Awake()
    {
        this.LoadCurrentMap();
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        MapInfinity newMap = other.transform.parent.GetComponent<MapInfinity>();
        if (newMap == null) return;

        this.currentMap.Set(this.mapCode, newMap);
        newMap.Set(this.mapCodeRelate, this.currentMap);
    }

    protected virtual void LoadCurrentMap()
    {
        this.currentMap = transform.parent.GetComponent<MapInfinity>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerMarker : MonoBehaviour
{
    public static SpinnerMarker instance;

    public string number;

    protected void Awake()
    {
        SpinnerMarker.instance = this;
    }

    protected void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        this.number = other.name;
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpinnerNumber : MonoBehaviour
{
    [SerializeField] protected TextMeshPro number;

    protected void Start()
    {
        this.ResetNumber();
    }

    protected virtual void ResetNumber()
    {
        this.number = GetComponent<TextMeshPro>();
        this.number.text = transform.name;
    }
}

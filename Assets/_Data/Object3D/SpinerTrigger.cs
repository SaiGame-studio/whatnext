using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinerTrigger : MonoBehaviour
{
    [SerializeField] protected Transform spiner;
    [SerializeField] protected float speed = 0f;
    [SerializeField] protected float speedMax = 700f;
    [SerializeField] protected float slowDown = 1f;

    protected void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        this.StartSpin();
    }

    protected virtual void StartSpin()
    {
        this.speed = this.speedMax;
    }

    protected void FixedUpdate()
    {
        this.Spinning();
    }

    protected void Spinning()
    {
        this.spiner.Rotate(0, Time.deltaTime * this.speed, 0);

        this.speed -= this.slowDown;
        if (this.speed < 0) this.speed = 0;
    }
}

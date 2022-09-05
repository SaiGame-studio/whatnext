using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerTrigger : MonoBehaviour
{
    [SerializeField] protected Transform spiner;
    [SerializeField] protected float speed = 0f;
    [SerializeField] protected float speedMax = 710f;
    [SerializeField] protected float slowDown = 7f;
    [SerializeField] protected string stopAt = "4";
    [SerializeField] protected bool stop = false;
    [SerializeField] protected bool spinning = true;

    protected void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        this.StartSpin();
    }

    protected virtual void StartSpin()
    {
        this.speed = this.speedMax;
        this.spinning = true;
        this.stop = false;

    }

    protected void FixedUpdate()
    {
        this.Spinning();
    }

    protected void Spinning()
    {
        this.spiner.Rotate(0, Time.deltaTime * this.speed, 0);

        this.Stoping();
    }

    protected void Stoping()
    {
        if (!this.stop) return;
        if (this.stopAt == SpinnerMarker.instance.number) this.spinning = false;
        if (this.spinning) return;

        this.speed -= this.slowDown;
        if (this.speed < 0) this.speed = 0;
    }
}

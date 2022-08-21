using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHP : MonoBehaviour, IHpBarInterface
{
    public int currentHP = 100;

    public int HP()
    {
        return this.currentHP;
    }
}


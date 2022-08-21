using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour, IHpBarInterface
{
    public int eHp = 50;

    public int HP()
    {
        return this.eHp;
    }
}

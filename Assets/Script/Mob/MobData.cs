using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobData
{
    private float hp;
    private float def;
    private float speed;

    public void MobDataSet(float hp, float def, float speed)
    {
        this.hp = hp;
        this.def = def;
        this.speed = speed;
    }

    public void TakeDamage(float damage)
    {

    }
}

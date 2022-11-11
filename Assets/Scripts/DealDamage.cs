using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : Card
{
    [field:SerializeField]int damage;
    public override void Use()
    {
        Debug.Log("Deal " + damage +" to "+ ChangeTarget());
    }
}

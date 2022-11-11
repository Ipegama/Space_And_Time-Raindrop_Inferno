using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    public int manaCost = 0;
    public Owner owner;

    public virtual void Use()
    {

    }

    public Owner ChangeTarget()
    {
        return (Owner)((int)owner * -1);
    }
}

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

    private void OnMouseEnter()
    {
        transform.Translate(0f, 1f, -1f);
        transform.Rotate(-15f,0f, 0f);
    }

    private void OnMouseExit()
    {
        transform.Translate(0f, -1f, 1f);
        transform.Rotate( 15f,0f, 0f);
    }
}

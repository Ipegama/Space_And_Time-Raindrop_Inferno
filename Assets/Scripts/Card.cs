using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    [field: SerializeField] private int manaCost { get; set; }
}

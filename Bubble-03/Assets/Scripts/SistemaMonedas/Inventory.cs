using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public int NumberOfDiamonds 
    {
        get;
        private set;
    }

    public UnityEvent<Inventory> Collected;

    public void DiamondCollected()
    { 
        NumberOfDiamonds++;
        Collected.Invoke(this);
    }
}

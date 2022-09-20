using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public  abstract class ICollectible : MonoBehaviour
{
    public static Action <int>ItemAcquired;
    [SerializeField] protected int itemCost;

    public virtual void Collect()
    {
        ItemAcquired?.Invoke(this.itemCost);
    }
}

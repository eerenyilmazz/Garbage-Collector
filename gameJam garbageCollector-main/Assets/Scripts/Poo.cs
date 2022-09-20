using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poo : ICollectible
{
    [SerializeField] GameObject Splatter;
    public override void Collect()
    {
        base.Collect();
        Splatter.SetActive(true);
        Splatter.transform.parent = null;
        Destroy(gameObject);
    }


}

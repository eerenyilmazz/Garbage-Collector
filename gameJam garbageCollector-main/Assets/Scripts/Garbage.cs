using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : ICollectible
{
    public override void Collect(){
        base.Collect();
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Barrel : ICollectible
{
    [SerializeField] GameObject Splatter;
    [SerializeField] ParticleSystem GreenExplosion;
    
   public override void Collect(){
     base.Collect();
      GreenExplosion.Play();
      GreenExplosion.transform.parent = null;
      Splatter.transform.parent = null;
      Splatter.SetActive(true);
      Destroy(gameObject);
      
    }
    
}

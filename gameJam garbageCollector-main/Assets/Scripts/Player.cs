using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
     if(other.gameObject.GetComponent<ICollectible>()!=null){
         other.gameObject.GetComponent<Collider>().GetComponent<ICollectible>().Collect();
     }   
    }
}

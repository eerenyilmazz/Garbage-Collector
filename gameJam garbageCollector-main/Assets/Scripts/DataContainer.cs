using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DataContainer : MonoBehaviour
{
    public static Action<int> AmountChanged;
    [SerializeField]int MaxRad;
    private int radAmount;

    public int RadAmount
    {
        get { return radAmount; }
        set {radAmount += value;AmountChanged?.Invoke(value);if(value >= 20){print("LevelCompleted");} }
    }
    private void OnEnable() {
        ICollectible.ItemAcquired += OnBarrelCollected;
    }
    private void OnDisable() {
        ICollectible.ItemAcquired -= OnBarrelCollected;
    }
    void OnBarrelCollected(int amount){
        RadAmount = amount;
    }
   void Awake(){
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField] Text radTxt; 
    [SerializeField] Slider radBar;
    [SerializeField] Text endTxt;
    private void OnEnable() 
    {
      DataContainer.AmountChanged += SetTxt;
    }
    private void OnDisable() {
        DataContainer.AmountChanged -= SetTxt;
    }
    void SetTxt(int amount)
    {
        radBar.value += amount;
        if(radBar.value == 100) endTxt.gameObject.SetActive(true);
        radTxt.text = radBar.maxValue-radBar.value+"";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coinTXT : MonoBehaviour
{
   public Text coinText;

   void Update()
{
    if (coinText != null)
    {
        coinText.text = Coin.coinCount.ToString();
    }
}


}



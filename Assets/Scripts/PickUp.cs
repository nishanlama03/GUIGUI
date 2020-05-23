using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    
        private float Coin = 0;

        public TextMeshProUGUI textCoin;
    // Update is called once per frame
    
       private void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.CompareTag("Player"))
        {
            Coin ++;
            textCoin.text = Coin.ToString();
         Destroy (other.gameObject);
        }
     } 
    
}

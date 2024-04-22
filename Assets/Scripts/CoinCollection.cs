using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    private int coins=0;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI ScoreText;

    // Start is called before the first frame update
   
   private void OnTriggerEnter(Collider other) {
     FindObjectOfType<AudioManager>().PlaySound("CoinPick");
    if(other.gameObject.tag=="coin"){
        coins++;
        coinText.text="Coins: "+(coins).ToString();
        ScoreText.text="Score: "+(coins*10).ToString();
        Destroy(other.gameObject);  
    }
   }
}

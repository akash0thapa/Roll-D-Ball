using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin;
    public Transform[] coinPoints;

    // Start is called before the first frame update

private void OnEnable()
{
    foreach (Transform child in gameObject.transform){
        if (child.CompareTag("coin")){
            Destroy(child.gameObject);
        }
    }
    foreach (Transform coinPos in coinPoints){
        GameObject mycoin= Instantiate(Coin,coinPos.position,Quaternion.identity);
       mycoin.transform.parent=gameObject.transform;
    }
    
}    
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

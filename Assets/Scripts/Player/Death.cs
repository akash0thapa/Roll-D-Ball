using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour
{
    public GameObject GameOverPanel;
  public void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag=="Player"){ 
         FindObjectOfType<AudioManager>().PlaySound("GameOver");
            Time.timeScale=0;
            GameOverPanel.SetActive(true);
    }
  }
}

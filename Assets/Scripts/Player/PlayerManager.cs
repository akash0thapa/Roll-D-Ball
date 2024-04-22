using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameOver;
    public GameObject GameOverPanel;
    public static bool GameStart;
    public GameObject startText;
    private void Start()
    {
        GameOver=false;
        Time.timeScale=1;
        GameStart=false;
    }

    // Update is called once per frame
    private void Update()
    {
        if(GameOver){
            Time.timeScale=0;
            GameOverPanel.SetActive(true);
        }
        if(Input.GetMouseButtonDown(0)) {
            GameStart=true;
            startText.SetActive(false);        }
            
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
public GameObject PausePanel;
public void ReplayGame(){
SceneManager.LoadScene("SampleScene");
}
public void QuitGame(){
Application.Quit();
}
public void Continue(){
     PausePanel.SetActive(false);
        Time.timeScale=1;
}
void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        PausePanel.SetActive(true);
        Time.timeScale=0;
    }
    }
}

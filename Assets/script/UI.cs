using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{
    public static bool GameIsPause;

    public Text scoreText;
    //public Text heartText;
    public Text highScoreText;
 
    public GameObject gameOverpanel;
    public GameObject PauseMenu;

    

  
    void Update() {
       if(Input.GetKeyDown(KeyCode.Escape))
       {
           if(GameIsPause){
               resume();
           }
           else{
               pasue();
           }
       }
   }
    public void resume(){
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause= false;

   }
   void pasue(){
PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause= true;
   }
    public void SetScoreText(string txt)
    {
        if (scoreText)
            scoreText.text = txt;
        
    }
  /*  public void SetHeartText(string txt)
    {
        if (heartText)
            heartText.text = txt;
    }*/
    public void SetHighScoreText(string txt)
    {
        if (highScoreText)
            highScoreText.text = txt;
    }
    public void ShowGameoverPanel(bool isShow)
    {
        if (gameOverpanel)
            gameOverpanel.SetActive(isShow);
            PauseMenu.SetActive(false);
            
            

    }
public void LoadMenu(){
    SceneManager.LoadScene("MainMenu");
}
public void QuitGame(){ 
    Application.Quit();
    Debug.Log("you quit...");
    
}

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    //public AudioSource audioMixer;
   public void ExitButton()
    {
        Application.Quit();
        Debug.Log("closed game");
    }

   // public void SetVolume(float volume){
       // Debug.Log(volume);
       //audioMixer.SetFloat("volume",volume);
      // audioMixer.volume = volume;
        

  //  }
    public void level1(){
        SceneManager.LoadScene("SampleScene");
    }
    public void level2(){
        SceneManager.LoadScene("level2");
    }

}

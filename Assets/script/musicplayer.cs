using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicplayer : MonoBehaviour
{
    // public Slider volumeSlider;
       
   public AudioSource AudioSource;
   private float MusicVolume = 1f;   
    // Start is called before the first frame update
    private void Start()
    {
        AudioSource.Play();
       // ObjectMusic = GameObject.FindWithTag("GameMusic");
       //AudioSource = ObjectMusic.GetComponents<AudioSource>();
       
        
       // MusicVolume = PlayerPrefs.GetFloat("volume");
        //AudioSource.volume = MusicVolume;
        //volumeSlider.value = MusicVolume;

    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume= MusicVolume;
       // PlayerPrefs.GetFloat("volume",MusicVolume);
    }
    public void UpdateVolume(float volume){
        MusicVolume = volume;
    }
}

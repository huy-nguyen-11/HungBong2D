using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume",1);
            Load();
        }
        else{
            Load();
        }
    }

    void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
    void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    void Save()
    {
PlayerPrefs.SetFloat("musicVolume",volumeSlider.value);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class soundScript : MonoBehaviour
{
    public  AudioClip bombSoundE , heartSoundE , ballSoundE , ballSoundE2;
    AudioSource audioSrc;
    // Start is called before the first frame update
     void Awake() {
        DontDestroyOnLoad(this.gameObject);

    }
    void Start()
    {
      //  bombSoundE = Resources.Load<AudioClip>("BombSound");
      //  heartSoundE = Resources.Load<AudioClip>("HeartSound");
       // ballSoundE = Resources.Load<AudioClip>("BallSound");
        audioSrc = GetComponent<AudioSource>();
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void PlaySound (string clip){


        switch(clip){
            case "BombSound":
            audioSrc.PlayOneShot(bombSoundE);
            break;
        }

        switch(clip){
            case "HeartSound":
            audioSrc.PlayOneShot(heartSoundE);
            break;
        }
        switch(clip){
            case "BallSound":
            audioSrc.PlayOneShot(ballSoundE);
            break;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    gameController m_gc;
    soundScript scr;
   void Start()
    {
        m_gc = FindObjectOfType<gameController>();
        scr = GameObject.FindWithTag("SoundM").GetComponent<soundScript>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            scr.PlaySound("HeartSound");
           gameController.health +=1;
            Destroy(gameObject);

          //  Debug.Log("nguoi choi hung duoc trai tim");

        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("deathZone"))
        {
           
            Destroy(gameObject);
           // Debug.Log("trai tim bi roi xuong vung chet");
            
        }
        if(col.gameObject.CompareTag("DestroyZone")){
            Destroy(gameObject);
           // Debug.Log("trai tim bi pha huy");
        }
    }
    

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
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
        //  soundScript.PlaySound("ballSound");
         scr.PlaySound("BallSound");
            m_gc.IncrementScore();
            Destroy(gameObject);

            Debug.Log("qua bong va cham");
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {

       if (col.gameObject.CompareTag("deathZone"))
        {
            scr.PlaySound("BombSound");
           // m_gc.DeceaseHeart();            
           gameController.health -=1;
            Destroy(gameObject);
           // Debug.Log("qua bong va cham voi vung deathZone");
           /* if(m_gc.heart <= 0)
            {
                m_gc.SetGameoverState(true);
            }*/
        }

        if(col.gameObject.CompareTag("DestroyZone")){
            Destroy(gameObject);
           // Debug.Log("qua bong bi pha huy");
        }
        
    }
    


}


   

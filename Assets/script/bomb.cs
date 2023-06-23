using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    gameController m_gc;
    soundScript scr;

    void Start()
    {
        m_gc = FindObjectOfType<gameController>();
       scr = GameObject.FindWithTag("SoundM").GetComponent<soundScript>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            scr.PlaySound("BombSound");
            gameController.health -=1;
            Destroy(gameObject);
           // Debug.Log("qua bom va cham voi nguoi choi");
           /* if (m_gc.i_heart <= 0)
            {
                m_gc.SetGameoverState(true);
               
            }*/
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("deathZone"))
        {
            Destroy(gameObject);
            //Debug.Log("qua bom va cham voi vung deathZone");
        }

        if(collision.gameObject.CompareTag("DestroyZone")){
            Destroy(gameObject);
            //Debug.Log("qua bom bi pha huy");
        }

    }

    
}

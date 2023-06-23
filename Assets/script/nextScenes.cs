using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScenes : MonoBehaviour
{
    // Start is called before the first frame update
    gameController m_gc;
    public void Start()
    {
        m_gc = FindObjectOfType<gameController>();
    }
    public void OnCollisionEnter2D(Collision2D collin)
    {

        if (collin.gameObject.CompareTag("Player"))
        {
            m_gc.PlusScore();
            Destroy(gameObject);

            //Debug.Log(" nextscenes va cham voi player");
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("deathZone"))
        {
                     
            Destroy(gameObject);
           // Debug.Log("chuyen scenes");
           
        }
        if(collision.gameObject.CompareTag("DestroyZone")){
            Destroy(gameObject);
            //Debug.Log(" bi pha huy");
        }
    }
}

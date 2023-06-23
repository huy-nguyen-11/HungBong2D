using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    gameController m_gc;
    soundScript scr;
    public float moveSpeed;
    float xDirection;
    float xPosittion;
    
    // Update is called once per frame
    void Update()
    {
       xDirection = Input.GetAxisRaw("Horizontal");

        float moveStep = xDirection * moveSpeed * Time.deltaTime;
        if ((transform.position.x <= -2.4f && xDirection < 0) || (transform.position.x >= 2.4f && xDirection > 0))
           return;

        transform.position = transform.position + new Vector3(moveStep, 0, 0);
    }

 /* private void FixedUpdate() {
        TouchMove();
    }

   void TouchMove(){
       if( Input.GetMouseButtonDown(0))
       {
           Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

           if(mousePos.x>1){
               transform.Translate(moveSpeed,0,0);
           }
           else if (mousePos.x < -1)
           {
               transform.Translate(-moveSpeed,0,0);
           }

       }
   }*/

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelGame : MonoBehaviour
{

   gameController mc_g;
   public Rigidbody2D ball;
   public Rigidbody2D ball2;
   public Rigidbody2D bombs;
   public Rigidbody2D heart;
   int lv;

private void Start() {
    mc_g = FindObjectOfType<gameController>();
   
   lv=1; 

    if(lv == 1){
      level1();
    }

    lv=2;
    if(lv==2){
      level2();
    }
}
  public  void level1()
  {
   

    ball.gravityScale=0.05f;
    ball2.gravityScale= 0.4f;
    bombs.gravityScale =0.06f;
    heart.gravityScale = 0.075f;
  }
  public void level2(){
   
    ball2.gravityScale = 0.8765f;
    bombs.gravityScale = 0.06f;
    heart.gravityScale= 0.075f;
  }
  
}

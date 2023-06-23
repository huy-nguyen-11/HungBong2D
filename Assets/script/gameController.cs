using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public GameObject ball;
    public GameObject bomb;
    public GameObject heart1, heart2, heart3,heart4;
    public static int health;
    public GameObject heart;
    public GameObject nextScenes;
    public float spawnTime;
   public  float m_spawnTime;
    public float n_spawnTime;
    public float i_spawnTime;
    public float j_spawnTime;
    


    int m_score;
    int h_score;
  // public int i_heart;
    bool m_isGameover;

    UI m_ui;

    // Start is called before the first frame update
    void Start()
    {
        //trang thai bat dau health =4
        health = 4;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        m_isGameover = false;

        Time.timeScale =1f;// sau khi quay ve tu scenes khac , thoi gian quay tro lai =0 nen minh phai dat cho no =1 de quay lai tg thuc.
        m_spawnTime = 0;
        n_spawnTime = 3;
        i_spawnTime = 5;
        j_spawnTime = 10;
        m_ui = FindObjectOfType<UI>();
        h_score=PlayerPrefs.GetInt("h_score",0);
        m_ui.SetScoreText("Score:" + m_score);
        //m_ui.SetHeartText("Heart:" + i_heart);
        m_ui.SetHighScoreText("HighScore:" + h_score );

    }

    // Update is called once per frame
    void Update()
    {
        //cap nhat health
        if (health > 4)
            health = 4;

        switch (health)
        {
            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                break;
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                m_isGameover= true ;
                Time.timeScale = 0;

                break;
        }

        m_spawnTime  -= Time.deltaTime;
        n_spawnTime -= Time.deltaTime;
        i_spawnTime -= Time.deltaTime;
        j_spawnTime -= Time.deltaTime;

        if (m_isGameover)
        {
            m_spawnTime = 0;
            n_spawnTime = 3;
            m_ui.ShowGameoverPanel(true);    
    
            return;
        }

        if(m_spawnTime <=0)
        {

            SpanwBall();
            m_spawnTime = spawnTime;
        }
        if(n_spawnTime <= 0)
        {
            SpawnBomb();
            n_spawnTime = spawnTime;
        }
        if (i_spawnTime <= 0)
        {
            SpawnHeart();
            i_spawnTime = spawnTime;
        }
        if (j_spawnTime <= 0)
        {
            SpawnnextScenes();
            j_spawnTime = spawnTime;
        }
    }
    public void SpanwBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);
        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }
    public void SpawnBomb()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);
        if (bomb)
        {
            Instantiate(bomb, spawnPos, Quaternion.identity);
        }
    }
    public void SpawnHeart()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);
        if (heart)
        {
            Instantiate(heart, spawnPos, Quaternion.identity);
        }
    }
    public void SpawnnextScenes()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);
        if (nextScenes)
        {
            Instantiate(nextScenes, spawnPos, Quaternion.identity);
        }
    }

    public void SetScore(int value)
    {
        m_score = value;
    }
    public int GetScore()
    {
        return m_score;
      
    }
   /* public void SetHeart(int value)
    {
        i_heart = value;
    }
    public int GetHeart()
    {
        return i_heart;
    }*/
    public void  IncrementScore()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
        if(h_score<m_score)
        PlayerPrefs.SetInt("h_score",m_score);
    }
    public void PlusScore(){
    m_score +=3;
   m_ui.SetScoreText("Score: " + m_score);
        if(h_score<m_score)
        PlayerPrefs.SetInt("h_score",m_score);
    }

    //public void IncerementHeart()
    //{
        //i_heart++;
       // m_ui.SetHeartText("Heart:" + i_heart);

        
   // }
    /*public void DeceaseHeart()
    {
        i_heart -= 1;
        if (i_heart <= 0)
        {
            i_heart = 0;
        }
        m_ui.SetHeartText("Heart:" + i_heart);
       
    }*/
    public bool Isgameover()
    {
        return m_isGameover;
    }
    public void SetGameoverState(bool state)
    {
        m_isGameover = state;
         Time.timeScale=0f;//thoi gian se bi ngung khi timescale=0.
    }
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("choi lai di");
        m_score = 0;
       // i_heart = 0;
        m_isGameover = false;
        m_ui.SetScoreText("Score:" + m_score);
       // m_ui.SetHeartText("Heart:" + i_heart);
        m_ui.ShowGameoverPanel(false);
        Time.timeScale=1f;// quay lai thoi gian thuc=1 
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}


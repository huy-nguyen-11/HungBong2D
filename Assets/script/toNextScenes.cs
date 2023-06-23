using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toNextScenes : MonoBehaviour
{
    public int loadScenes;

    public void Start()
    {
        loadScenes = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

            SceneManager.LoadScene(loadScenes);
    }
}

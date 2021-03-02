using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audioscript : MonoBehaviour
{
    private static Audioscript instance;

    void Update() {
        if (SceneManager.GetActiveScene().name == "Level Select") 
        {
            if(Input.GetMouseButtonDown(0)) {
                Debug.Log(SceneManager.GetActiveScene().name);
            }
            Destroy(gameObject);
        }
    }
    void Awake ()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject); 
        }
    }
}

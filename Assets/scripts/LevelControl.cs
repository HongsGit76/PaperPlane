using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public Button level02Button, level03Button, level04Button;
    private int levelpassed;

    // Start is called before the first frame update
    void Start()
    {
        levelpassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = true;
        level03Button.interactable = true;
        level04Button.interactable = true;

        switch(levelpassed){
        case 2:
            level02Button.interactable = true;
            break;
        case 3:
            level02Button.interactable = true;
            level03Button.interactable = true;
            break;
        case 4:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefs()
    {
        level02Button.interactable = false;
        level03Button.interactable = false;
        level04Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}

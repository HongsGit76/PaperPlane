using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChargeSecondscene_floor1()
    {
        SceneManager.LoadScene("LEVEL 1");
    }
    public void ChargeSecondscene_floor2()
    {
        SceneManager.LoadScene("LEVEL 2");
    }
    public void ChargeSecondscene_floor3()
    {
        SceneManager.LoadScene("LEVEL 3");
    }
    public void ChargeSecondscene_floor4()
    {
        SceneManager.LoadScene("LEVEL 4");
    }
    public void ChargeSecondscene_level_select()
    {
        SceneManager.LoadScene("Level Selcet");
    }
    public void ChargeSecondscene_main_menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}

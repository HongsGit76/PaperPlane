using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taptostart : MonoBehaviour
{
    public GameObject tapUI;
    // Start is called before the first frame update
    void Start()
    {
        tapUI.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            tapUI.gameObject.SetActive(false);
            
        }
    }
}

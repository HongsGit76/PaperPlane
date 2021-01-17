using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioClip buttonclicked;
    public AudioSource audioSource;
    public void ClickSound()
    {
        audioSource.PlayOneShot (buttonclicked);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

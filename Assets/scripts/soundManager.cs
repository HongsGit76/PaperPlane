using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public AudioListener audioListener;
    public List<AudioSource> audioSources;


    void OnMouseDown() {
        foreach(AudioSource audioSorce in audioSources) {
            audioSorce.Stop();
        }
        /*
        if(audioListener != null) {
            audioListener.enabled = false;
        }
        */
    }
}

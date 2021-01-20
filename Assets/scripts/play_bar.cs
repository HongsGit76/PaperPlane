using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class play_bar : MonoBehaviour
{
    public GameObject bar;
    public GameObject mini_plane;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
        MovePlane();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AnimateBar()
    {
        LeanTween.scaleX(bar,1,time);
    }

    public void MovePlane()
    {
        LeanTween.moveX(mini_plane, 9f, time);
    }
}

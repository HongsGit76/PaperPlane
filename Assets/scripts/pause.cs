using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public bool isPause;
    public void IsPause()
    {
        if(isPause == false)
        {
            Time.timeScale = 0f;
            this.isPause = true;
        }
        else
        {
            Time.timeScale = 1f;
            this.isPause = false;
        }
    }
}

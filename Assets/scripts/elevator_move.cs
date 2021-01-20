using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator_move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    //public int direction = 1;  // 1 is right 2 is left
    public int direction; // 1 = right 0 = left

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {   
        if (direction == 1){
            transform.position += Vector3.right * speed * Time.deltaTime;
        }else{
            transform.position -=  Vector3.right * speed * Time.deltaTime;
        }
    }
    
}

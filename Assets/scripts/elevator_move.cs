using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator_move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int direction = 1;  // 1 is right 2 is left
    private float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (direction == 1){
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (direction == 0){
            transform.position -= Vector3.right * speed * Time.deltaTime;
        }
        
        
    }
}

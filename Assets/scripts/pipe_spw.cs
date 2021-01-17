using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spw : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject object_1;
    public GameObject object_2;
    public GameObject object_3;
    public GameObject object_4;
    public GameObject object_5;
    public float height_1;
    public float height_2;
    public float height_3;
    public float height_4;
    public float height_5;
    private int rannum;
    private int passing = 0;
    public int boss = 50;
    public float speed = 0;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
         if (timer > maxTime)
        {
            rannum = UnityEngine.Random.Range(1, 6);
            if (rannum == 1)
            {
                GameObject newob_1 = Instantiate(object_1);
                newob_1.transform.position = transform.position + new Vector3(0, height_1, 0);
                Destroy(newob_1, 15);
                move mv = newob_1.transform.GetComponent<move>();
                mv.speed += speed;
                timer = 0;
            }
            else if (rannum == 2)
            {
                GameObject newob_2 = Instantiate(object_2);
                newob_2.transform.position = transform.position + new Vector3(0, height_2, 0);
                Destroy(newob_2, 15);
                move mv = newob_2.transform.GetComponent<move>();
                mv.speed += speed;
                timer = 0;
            }
            else if (rannum == 3)
            {
                GameObject newob_3 = Instantiate(object_3);
                newob_3.transform.position = transform.position + new Vector3(0, height_3, 0);
                Destroy(newob_3, 15);
                move mv = newob_3.transform.GetComponent<move>();
                mv.speed += speed;
                timer = 0;
            }
            else if (rannum == 4)
            {
                GameObject newob_4 = Instantiate(object_4);
                newob_4.transform.position = transform.position + new Vector3(0, height_4, 0);
                Destroy(newob_4, 15);
                move mv = newob_4.transform.GetComponent<move>();
                mv.speed += speed;
                timer = 0;
            }
            else if (rannum == 5)
            {
                GameObject newob_5 = Instantiate(object_5);
                newob_5.transform.position = transform.position + new Vector3(0, height_5, 0);
                Destroy(newob_5, 15);
                move mv = newob_5.transform.GetComponent<move>();
                mv.speed += speed;
                timer = 0;
            }
        }

        timer += Time.deltaTime;

        if (boss < passing)
        {
            Debug.Log("boss");
        }
        
    }
}

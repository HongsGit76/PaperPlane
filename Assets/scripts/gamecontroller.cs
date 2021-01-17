using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    private float speedChange = 0;
    // Start is called before the first frame update
    void Start()
    {
        move mv = GameObject.Find("spawner").GetComponent<move>();
        mv.speed += Time.deltaTime*10;
    }

    // Update is called once per frame
    void Update()
    {
        move mv = transform.Find("spawner").GetComponent<move>();
        mv.speed += speedChange;
        speedChange += Time.deltaTime * 10;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject leftDoor;
    public GameObject rightDoor;
    void Start()
    {
        GameObject l = Instantiate(leftDoor);
        GameObject r = Instantiate(rightDoor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

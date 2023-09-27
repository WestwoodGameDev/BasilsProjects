using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstacle;
    private long pastFrame;

    void Start()
    {
        pastFrame = Time.frameCount;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount - pastFrame < 50){
            Instantiate(obstacle);
        }
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    private float Timer = 0f;
    public float hightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
       spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= spawnRate)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            Timer = 0f;
        }
    }
    
    void spawnPipe()
    {
    float lowestPoint = transform.position.y - hightOffset;
    float highestPoint = transform.position.y + hightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,UnityEngine.Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}

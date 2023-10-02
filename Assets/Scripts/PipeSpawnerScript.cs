using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    //reference prefab
    public GameObject pipe;
    //pembatas munculnya pipe
    public float spawnRate = 2;
    public float timer = 0;

    public float hightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }

    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - hightOffset;
        float highestPoint = transform.position.y + hightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipes;
    private float timer = 0;
    public float rateOfSpawn;
    public float heightOffSet;
    void Start()
    {
       SpawnPipe(); 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > rateOfSpawn) 
        {
            SpawnPipe();
            timer = 0;
            
        }
    }
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;

        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}

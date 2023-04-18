using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBird : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bird;

    public float spawnStartDelay = 1f;
    public float repeatDelay = 2f;

    void Start()
    {
        InvokeRepeating("BirdMaker", spawnStartDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void BirdMaker()
    {
        Vector3 randomLocation = new Vector3(Random.Range(-10, 10), transform.position.y, transform.position.z);
        Instantiate(bird,randomLocation, bird.transform.rotation);
    }
}

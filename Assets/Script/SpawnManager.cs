using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float timeSpawn = 4;
    public GameObject prefabsBird;
    public Transform parrentBird;
    public Transform parrentPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeSpawn -= Time.deltaTime;
        if (timeSpawn < 0)
        {
            Vector3 positionSpawn = parrentPosition.position;
            positionSpawn.x = Random.Range(-9f, 9f);
            positionSpawn.y = Random.Range(-5.2f, 5.2f);
            Instantiate(prefabsBird, positionSpawn, Quaternion.identity, parrentBird);
            timeSpawn = Random.Range(2f, 4f);
           
        }
    }
}

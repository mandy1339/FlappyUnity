using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public float timeInterval;
    float counter;
    public GameObject column;
    public float upperDist, lowerDist;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter >= timeInterval)
        {
            counter = 0;
            // spawn a pipe
            GameObject newColumn = Instantiate(column);
            newColumn.transform.position = (Vector2)transform.position + new Vector2(0, Random.Range(upperDist, -lowerDist));
        }
        counter += Time.deltaTime;
    }
}

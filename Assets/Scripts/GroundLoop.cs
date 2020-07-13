using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x <= -3.12)
        {
            this.transform.position = new Vector3(3.6f, this.transform.position.y, 0);
        }
    }
}

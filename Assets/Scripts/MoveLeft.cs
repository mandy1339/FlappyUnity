using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector2.left * speed;
        this.transform.position = new Vector3(this.transform.position.x - speed * Time.deltaTime,this.transform.position.y,0);
    }
}

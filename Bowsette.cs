using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowsette : MonoBehaviour
{
    public float speed = 20f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento horizontal
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);

        //Movimiento vertical
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "estrella")
        {
            Destroy(col.gameObject);
        }
    }

}

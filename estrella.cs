using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrella : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        var numero = Random.Range(1, 50);
        if (numero < 25)
        {
            transform.localScale = new Vector3(0f, 0f, 0f);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}

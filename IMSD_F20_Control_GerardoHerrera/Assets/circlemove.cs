using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlemove : MonoBehaviour
{
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            myTransform.position += new Vector3(0, .1f, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myTransform.position += new Vector3(0, .1f, 0);
        }
    }
}

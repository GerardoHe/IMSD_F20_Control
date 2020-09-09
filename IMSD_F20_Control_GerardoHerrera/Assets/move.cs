using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3(-10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = myTransform.position + new Vector3(.001f, 0, 0);
    }
}

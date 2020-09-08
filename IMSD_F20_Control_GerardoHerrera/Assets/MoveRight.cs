using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public Transform myTransform;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3(-10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = myTransform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}

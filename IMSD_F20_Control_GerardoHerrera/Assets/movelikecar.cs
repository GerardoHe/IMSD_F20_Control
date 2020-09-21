
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class movelikecar : MonoBehaviour
{
    private Transform myTransform;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        speed = Random.Range(1.00f, 3.00f);
    }
    // Update is called once per frame
    void Update()
    {
        myTransform.position += Vector3.right * Time.deltaTime * speed;
    }
}

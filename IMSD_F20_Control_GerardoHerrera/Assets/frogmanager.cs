using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject frog;

    public GameObject frogPrefab;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (frog != null)
                Destroy(frog);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (frog == null)
            frog = Instantiate(frogPrefab, new Vector3(5, 5, 68), Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotção : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x: 1, y: 0, z: 0));
    }
}

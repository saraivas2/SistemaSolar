using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scritp_saturno : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var speed = 2.0; 
        transform.Rotate(Vector3.up,(float) (Time.deltaTime*speed));
    }
}

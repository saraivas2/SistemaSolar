using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras1_2 : MonoBehaviour
{
    [SerializeField] private Camera cam1;
    [SerializeField] private Camera cam2;

    private void Start()
    { 
     cam1 = cam1.GetComponent<Camera>();
     cam2 = cam2.GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ligarCamera1();
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            ligarCamera2();
        }
    }

    void ligarCamera1()
    {
        cam1.enabled = true;
        cam2.enabled = false;   
    }

    void ligarCamera2()
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }
}

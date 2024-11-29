using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras3_4 : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Camera cam1;
    [SerializeField] private Camera cam2;
    [SerializeField] private float vel;
    float fild1, fild2;
    Vector3 posicaoNave, posicaoCamera;

    private void Start()
    {
        player = player.GetComponent<Transform>();
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
        fild1 = cam1.fieldOfView;
        fild2 = cam2.fieldOfView;
    }

    void FixedUpdate()
    {
        if (cam1.enabled & fild1 == 30f)
        {
            AfastarCamera1();
        }
        else if (cam2.enabled & fild1 == 60f)
        {
            AproximarCamera1();
        }

    }

    void AproximarCamera1()
    {
        cam1.fieldOfView = Mathf.Lerp(65f, 30f, 0.01f * Time.deltaTime);

    }
    void AfastarCamera1()
    {
        cam1.fieldOfView = Mathf.Lerp(30f, 60f, 0.01f * Time.deltaTime);
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
        AproximarCamera1();
    }
}

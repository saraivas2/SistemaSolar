using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_nave : MonoBehaviour
{
    // Start is called before the first frame update
    public bool travarMouse = true;
    public float sensibilidade = 1.2f;
    private float velocidade;
    private float aceleracao = 5.0f;
    private Vector3 direcao;
    private float mouseX=0.0f, mouseY=0.0f;
    

    void Start()
    {
        velocidade = 3;
        direcao = Vector3.zero;

        if (!travarMouse)
        {
            return;
        }
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        InputPersonagem();
        transform.Translate(direcao * velocidade * Time.deltaTime);
        // Smoothly tilts a transform towards a target rotation.
        mouseY += Input.GetAxis("Mouse X") * sensibilidade;
        mouseX += Input.GetAxis("Mouse Y") * sensibilidade;

        transform.eulerAngles = new Vector3(mouseX, mouseY,0);

    }

    void InputPersonagem()
    {
        direcao = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direcao += Vector3.forward * aceleracao;
            if (aceleracao < 50)
            {
                aceleracao += 2;
            }
            
        }
        else
        {
            if (aceleracao > 5)
            {
                aceleracao -= 1;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            direcao += Vector3.right;
         
        }
        if (Input.GetKey(KeyCode.D))
        {
            direcao += Vector3.left;
        
        }
        if (Input.GetKey(KeyCode.S))
        {
            direcao += Vector3.back * aceleracao;
            if (aceleracao < 50)
            {
                aceleracao += 2;
            }
        }
        else
        {
            if (aceleracao > 5)
            {
                aceleracao -= 1;
            }
        }
    }
}

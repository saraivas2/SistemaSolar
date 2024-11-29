using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_nave2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool travarMouse = true;
    public float sensibilidade = 1.2f;
    private float velocidade;
    private float aceleracao = 3.0f;
    private float turbo = 2.0f;
    private Vector3 direcao;
   
    void Start()
    {
        velocidade = 3;
        direcao = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        InputPersonagem(); 
    }

    private void FixedUpdate()
    {
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    void InputPersonagem()
    {
        direcao = Vector3.zero;
        
        if (Input.GetKey(KeyCode.Q))
        {
            turbo = 2.0f;

        }
        else
        {
            turbo = 1.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direcao += Vector3.forward * aceleracao * turbo;
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao += Vector3.right;
         
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao += Vector3.left;
        
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direcao += Vector3.back * aceleracao * turbo;
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

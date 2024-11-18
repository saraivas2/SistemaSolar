using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_text_sol : MonoBehaviour
{
    public GameObject Planeta;
    public GameObject Nave;
    public TextMesh Text_Terra;

    // Distâncias para controle de visibilidade e tamanho
    private float maxDistance = 200f;
    private float minDistance = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            // Calcula a distância entre Terra e Nave
            float distancia = Vector3.Distance(Planeta.transform.position, Nave.transform.position);

            // Atualiza o texto com a distância
            Text_Terra.text = "Sol " + distancia.ToString("F2");

            // Controle da visibilidade e tamanho do TextMesh com base na distância
            if (distancia > maxDistance)
            {
                Text_Terra.characterSize = 10f*distancia/200; // Tamanho máximo
                Text_Terra.color = Color.white; // Cor visível
                Text_Terra.gameObject.SetActive(true);
        }
            else if (distancia < minDistance)
            {
                Text_Terra.gameObject.SetActive(true);
        }
            else
            {
                // Ajusta o tamanho proporcionalmente entre minDistance e maxDistance
                float normalizedDistance = (distancia - minDistance) / (maxDistance - minDistance);
                Text_Terra.characterSize = Mathf.Lerp(0.1f, 1f, normalizedDistance);

                // Ajusta a cor para visibilidade gradual
                Text_Terra.color = Color.Lerp(Color.clear, Color.white, normalizedDistance);
            }
        
    }
}

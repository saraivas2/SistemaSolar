using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script_text_plutao : MonoBehaviour
{
    public GameObject Sol;
    public GameObject Mercurio;
    public GameObject Venus;
    public GameObject Terra;
    public GameObject Marte;
    public GameObject Jupiter;
    public GameObject Saturno;
    public GameObject Urano;
    public GameObject Netuno;
    public GameObject Plutao;
    public GameObject Nave;

    public TextMesh Text_Nave;

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
            float sol = Vector3.Distance(Sol.transform.position, Nave.transform.position);
            float mercurio = Vector3.Distance(Mercurio.transform.position, Nave.transform.position);
            float venus = Vector3.Distance(Venus.transform.position, Nave.transform.position);
            float terra = Vector3.Distance(Terra.transform.position, Nave.transform.position);
            float marte = Vector3.Distance(Marte.transform.position, Nave.transform.position);
            float jupiter = Vector3.Distance(Jupiter.transform.position, Nave.transform.position);
            float saturno = Vector3.Distance(Saturno.transform.position, Nave.transform.position);
            float urano = Vector3.Distance(Urano.transform.position, Nave.transform.position);
            float netuno = Vector3.Distance(Netuno.transform.position, Nave.transform.position);
            float plutao = Vector3.Distance(Plutao.transform.position, Nave.transform.position);
            
       
            
            // Controle da visibilidade e tamanho do TextMesh com base na distância
            if (sol <= mercurio)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Sol: " + sol.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
                
            }
            else if (mercurio <= venus)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Mercurio: " + mercurio.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
                
            }
            else if (venus <= terra)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Venus: " + venus.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
                
            }
            else if (terra <= marte)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Terra: " + terra.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
                
            }
            else if (marte <= jupiter)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Marte: " + marte.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
                
            }
            else if (jupiter <= saturno)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Jupiter: " + jupiter.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
               
            }
            else if (saturno <= urano)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Saturno : " + saturno.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
                                               
            }
            else if (urano <= netuno)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Urano: " + urano.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
               
            }
            else if (netuno <= plutao)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Netuno: " + netuno.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
                
            }
            else if (plutao < netuno)
            {
                // Atualiza o texto com a distância
                Text_Nave.text = "Plutão: " + plutao.ToString("F2");
                Text_Nave.color = Color.white; // Cor visível
                
            }
    }
}

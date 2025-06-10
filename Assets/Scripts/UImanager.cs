using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UImanager : MonoBehaviour
{
    public DineroManager dineroManager;
    public Vidamanager vidamanager;
    public TextMeshProUGUI contador;
    public TextMeshProUGUI contadorvida;
    float Plata;
    float Vida;

    // Start is called before the first frame update
    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
        vidamanager = FindObjectOfType<Vidamanager>();
    }

    // Update is called once per frame
    void Update()
    {
        Plata = dineroManager.playerMoney;
        Vida = vidamanager.playervida;
        contador.text = "Plata: " + Plata.ToString();
        contadorvida.text = "Vida: " + Vida.ToString();
    }

    
            
            
      
    }


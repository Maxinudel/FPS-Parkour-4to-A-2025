using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UImanager : MonoBehaviour
{
    public DineroManager dineroManager;
    public TextMeshProUGUI contador;
    float Plata;

    // Start is called before the first frame update
    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Plata = dineroManager.playerMoney;
        contador.text = Plata.ToString();
    }

    
            
            
      
    }


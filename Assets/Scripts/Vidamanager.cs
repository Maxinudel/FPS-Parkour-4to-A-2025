using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidamanager : MonoBehaviour
{
    public float playervida;


    public bool UpdateHealth(float amount)
    {

        if (playervida + amount < 0)
        {
            //impedir compra
            return false;
        }
        else
        {
            playervida += amount;
            return true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDano : MonoBehaviour
{
    public int dano = 10;
    public Vidamanager vidamanager;

    void Start()
    {
       vidamanager = FindObjectOfType<Vidamanager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //restar precio al dinero del player
            if (vidamanager.UpdateHealth(-dano) == true)
            {
                Destroy(gameObject);

            }
            else { }
        }
    }
}

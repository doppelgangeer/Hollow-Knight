using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hollow : Movimiento
{

    [SerializeField] private float vida;

    public void TomarDaño(float daño)
    {
        vida -= daño;

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    
    // Update is called once per frame
    void Update()
    {

        moverse(5);
        Jump(15);
       
          
    }
   
}

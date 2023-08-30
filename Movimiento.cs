using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    private float teclaMovimiento;
    private Rigidbody2D Caminar;
    private bool contacto;
    public bool sePuedeMover;


    private void Start()
    {
        Caminar = GetComponent<Rigidbody2D>();
    
    }
    

    protected virtual void moverse(float velocidad)
    {
        teclaMovimiento = Input.GetAxis("Horizontal");
        Caminar.velocity = new Vector2(teclaMovimiento * velocidad, Caminar.velocity.y);
        if (teclaMovimiento < 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else if(teclaMovimiento>0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
    }

    public virtual void Jump(float fuerzaSalto)
    {
        if (Physics2D.Raycast(transform.position, Vector3.down * 0.5f))
        {
            contacto = true;
        }
        else if (contacto == false) {
        
        }
        
        if (Input.GetKeyDown(KeyCode.W) && contacto){
            Caminar.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

  



}

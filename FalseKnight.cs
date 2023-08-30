using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseKnight : MonoBehaviour
{
    [SerializeField] public Transform Hollow;
    [SerializeField] private float distancia;
    
    public Vector3 puntoInicial;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    

    private void Start()
    {
        animator = GetComponent<Animator>();
        puntoInicial = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();   

    }

    private void Update()
    {
        distancia = Vector2.Distance(transform.position, Hollow.position);
        animator.SetFloat("Distancia", distancia);

    }

    public void Girar(Vector3 objetivo)
    {
        if (transform.position.x < objetivo.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    

}

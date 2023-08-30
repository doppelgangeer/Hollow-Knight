using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hollow_Animaciones : MonoBehaviour
{
    Animator animacionesjiji;
    bool isRunning = false;
    bool isSprinting = false;
    bool isJumping = false;
    bool isClimbing = false;
    bool isAttacking = false;
    bool isAttackUp = false;
    bool isAttackDown = false;
    //bool isGrounded = true;
    bool isJumpFirst = false;
    bool isJumpSecond = false;
    bool Rotate = false;
    //bool isHurt = false;
    bool isDead = false;

    void Start()
    {
        animacionesjiji = GetComponent<Animator>();
    }

    void Update()
    {
        // animación de correr y detenerse
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (isRunning && isSprinting)
            {
                animacionesjiji.SetBool("IsRun", false);
                animacionesjiji.ResetTrigger("stopTrigger");
                isRunning = false;
                isSprinting = false;
            }
            else
            {
                animacionesjiji.SetBool("IsRun", true);
                animacionesjiji.ResetTrigger("stopTrigger");
                isRunning = true;
                isSprinting = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (isRunning && isSprinting)
            {
                animacionesjiji.SetBool("IsRun", false);
                animacionesjiji.ResetTrigger("stopTrigger");
                isRunning = false;
                isSprinting = false;
            }
            else
            {
                animacionesjiji.SetBool("IsRun", true);
                animacionesjiji.ResetTrigger("stopTrigger");
                isRunning = true;
                isSprinting = false;
            }
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            if (isRunning && !isSprinting)
            {
                animacionesjiji.SetBool("IsRun", false);
                animacionesjiji.ResetTrigger("stopTrigger");
                isRunning = false;
                isSprinting = false;
            }
        }

        // animación de salto
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!isJumping)
            {
                animacionesjiji.SetBool("IsJump", true);
                animacionesjiji.SetBool("IsJumpFirst", true);
                isJumping = true;
            }
            else if (isJumpFirst)
            {
                animacionesjiji.SetBool("IsJumpFirst", false);
                animacionesjiji.SetTrigger("IsJumpSecond");
                isJumpFirst = false;
                isJumpSecond = true;
            }
            else if (isClimbing)
            {
                animacionesjiji.SetTrigger("IsClimbJump");
            }
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            if (isJumping)
            {
                animacionesjiji.SetBool("IsJump", false);
                isJumping = false;
            }
            else if (isJumpSecond)
            {
                animacionesjiji.SetTrigger("IsJumpStandby");
                isJumpSecond = false;
            }
        }

        // animación de trepar
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!isClimbing)
            {
                animacionesjiji.SetBool("IsClimb", true);
                isClimbing = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            if (isClimbing)
            {
                animacionesjiji.SetBool("IsClimb", false);
                isClimbing = false;
            }
        }

        // animación de agacharse
        //animacionesjiji.SetBool("IsDown", Input.GetKey(KeyCode.S));

        // animación de bajar por pared
        //animacionesjiji.SetBool("IsWallSlide", Input.GetKey(KeyCode.S));

        // animación de ataque
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animacionesjiji.SetTrigger("IsAttack");
            isAttacking = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            isAttacking = false;
        }

        // animación de ataque hacia arriba
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            animacionesjiji.SetTrigger("IsAttackUp");
            isAttackUp = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            isAttackUp = false;
        }

        // animación de ataque hacia abajo
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            animacionesjiji.SetTrigger("IsAttackDown");
            isAttackDown = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse2))
        {
            isAttackDown = false;
        }

        // animación de estar en el suelo
        //animacionesjiji.SetBool("IsGround", isGrounded);

        // animación de rotación
        if (Input.GetKeyDown(KeyCode.R))
        {
            animacionesjiji.SetTrigger("IsRotate");
            Rotate = true;
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            Rotate = false;
        }

        // animación de herida
        // if (Input.GetKeyDown(KeyCode.H))
        {
            //     animacionesjiji.SetTrigger("IsHurt");
            //    isHurt = true;
            // }
            //else if (Input.GetKeyUp(KeyCode.H))
            //{
            //    isHurt = false;
            //}

            // animación de muerte
            if (Input.GetKeyDown(KeyCode.P))
            {
                animacionesjiji.SetTrigger("IsDead");
                isDead = true;
            }
            else if (Input.GetKeyUp(KeyCode.P))
            {
                isDead = false;
            }

            // Ejemplo: otras animaciones que no están relacionadas con teclas
            //animacionesjiji.SetTrigger("isLanding");
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public InputManager inputManager;
  
   public void Update ()
    {   //AIM
        if (Input.GetMouseButtonDown(1))
        {
            inputManager.Aiming();
        }
        if (inputManager.isAiming && Input.GetMouseButtonDown(1))
        {
            inputManager.NotAiming();
        }

        //CROUCH
        if (Input.GetKeyDown(KeyCode.C))
        {
            inputManager.Crouching();
        }
        if (Input.GetKeyUp(KeyCode.C) && inputManager.isCrouching)
        {
            inputManager.NotCrouching();
        }

        //RUNBACKWARDS
        if (Input.GetKeyDown(KeyCode.S))
        {
            inputManager.RunBackwards();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            inputManager.RunBackwardsFalse();
        }
        //RUNFORWARD
        if (Input.GetKeyDown(KeyCode.W))
        {
            inputManager.RunForward();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            inputManager.RunForwardFalse();
        }
        //JUMP
        if (Input.GetKeyDown(KeyCode.F))
        {
            inputManager.Jump();
        }
        //SHOOT
        if (Input.GetButtonDown("Fire1"))
        {
            inputManager.Shooting();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            inputManager.ShootingFalse();
        }
        //RUNLEFTSIDE
        if (Input.GetKeyDown(KeyCode.A))
        {
            inputManager.RunLeftSide();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            inputManager.RunLeftSideFalse();
        }
        //RUNRIGHTSIDE
        if (Input.GetKeyDown(KeyCode.D))
        {
            inputManager.RunRightSide();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            inputManager.RunRightSideFalse();
        }
    }
}

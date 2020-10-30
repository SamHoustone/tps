using UnityEngine;

public class InputManager : MonoBehaviour
{
    ///references
    public Animator animator;
    public AimDownSight aimdownsight;
    public Rigidbody rb;
    public GameObject gun;

    ///float
    public float jumpSpeed;
    
    //booleans
    public bool isAiming = false;
    public bool jump = false;
    public bool isCrouching = false;
    public bool canMove = true;

    //AIM
    public void Aiming()
    {
        animator.SetBool("aim", true);
        isAiming = !isAiming;
    }
    public void NotAiming()
    {
            animator.SetBool("aim", false);
        
    }
    //CROUCH
    public void Crouching ()
    { 
            animator.SetBool("crouch", true);
            isCrouching = !isCrouching;
    }
    public void NotCrouching ()
    {
        animator.SetBool("crouch", false);
    }
    //BACKWARDS
   public void RunBackwards ()
   {
                animator.SetBool("runback", true);

   }
    public void RunBackwardsFalse ()  
    {
                animator.SetBool("runback", false);

    }
    //RUNFORWARD
     public void RunForward() 
     {
                animator.SetBool("runforward", true);
     }
     public void RunForwardFalse()
     {
        animator.SetBool("runforward", false);
     } 
    //JUMP
      public void Jump()
      {
        animator.SetBool("jump", true);
    }
    //SHOOT
     public void Shooting ()
     {
                animator.SetBool("is_Shooting", true);
     }
     public void ShootingFalse ()
     {
                animator.SetBool("is_Shooting", false);
     } 
     //RUNLEFTSIDE
     public void RunLeftSide()
     {
                animator.SetBool("sa", true);
     }


    public void RunLeftSideFalse ()
    {
                animator.SetBool("sa", false);
    }
    //RUNRIGHTSIDE
    public void RunRightSide()
            {
                animator.SetBool("sd", true);
            }
    public void RunRightSideFalse()
            {
                animator.SetBool("sd", false);
            }
}


using UnityEngine;

public class PLAYER_MOVEMENT : MonoBehaviour
{

    public Animator animator;
    CharacterController characterController;
    public bool canMove = true;
    public Rigidbody rb;
    public GameObject gun;
    public CharacterController controller;
    bool jump = false;
    public float jumpSpeed;

    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2"))
        {



            animator.SetBool("aim", true);
        }
        if (Input.GetButtonUp("Fire2"))
        {


            animator.SetBool("aim", false);
        }

        //crouch

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("crouch", true);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("crouch", false);
        }


        //backwards
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("runback", true);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("runback", false);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("runforward", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("runforward", false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {

            animator.SetBool("jump", true);

        }



        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("is_Shooting", true);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("is_Shooting", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("sa", true);
        }


        if (Input.GetKeyUp(KeyCode.A) )
        {
            animator.SetBool("sa", false);
        }

        if (Input.GetKeyDown(KeyCode.D) )
        {
            animator.SetBool("sd", true);
        }


        if (Input.GetKeyUp(KeyCode.D) )
        {
            animator.SetBool("sd", false);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            animator.SetBool("prone", true);
        }


        if (Input.GetKeyUp(KeyCode.V))
        {
            animator.SetBool("prone", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("jump2", true);
        }

        if (characterController.isGrounded)
        {
            animator.SetBool("jump2", false);
        }
        



    }
}


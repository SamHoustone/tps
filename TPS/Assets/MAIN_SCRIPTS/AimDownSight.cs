using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimDownSight : MonoBehaviour
{
    public Vector3 aimDownSights;
    public Quaternion aimDownSightsRotation;
    public GameObject cam1;
    public GameObject cam2;
    public Vector3 hipFire;
    public float aimspeed;
    public Vector3 offset;

    public PLAYER_MOVEMENT playermovement;


    public bool isAiming = false;

    public transform bulletTransform;

    public Guns gun;

    public void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }



    void Update()
    {
        
        
        
            if (Input.GetMouseButtonDown(1))
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
            isAiming = !isAiming;

            

            }
            if (isAiming && Input.GetMouseButtonDown(1))
            {
                cam1.SetActive(true);
                cam2.SetActive(false);

            


        }



    }



}

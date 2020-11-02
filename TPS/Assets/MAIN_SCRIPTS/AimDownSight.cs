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
    InputManager inputManager;
    public bool isAiming = false;
    public Canvas crosshair;

    public void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }



    void Update()
    {
        
        
        
            if (Input.GetMouseButtonDown(1))
            {
                cam1.GetComponent<Camera>().enabled = false;
                crosshair.enabled = false;
                cam2.SetActive(true);
                isAiming = !isAiming;

            

            }
            if (isAiming && Input.GetMouseButtonDown(1))
            {
             cam1.GetComponent<Camera>().enabled = true;
             crosshair.enabled = true;
             cam2.SetActive(false);

            


        }



    }



}

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



    void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            cam1.SetActive (false);
            cam2.SetActive(true);
           

            

        }
        else
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            transform.localPosition = Vector3.Slerp(transform.localPosition, hipFire, aimspeed * Time.deltaTime);
        }

        
    }
}
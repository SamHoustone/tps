using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimDownSight : MonoBehaviour
{
    public Vector3 aimDownSights;
    public Quaternion aimDownSightsRotation;
    public Vector3 hipFire;
    public float aimspeed;



    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition, aimDownSights, aimspeed * Time.deltaTime);
            transform.localRotation = Quaternion.Slerp(transform.rotation, aimDownSightsRotation, aimspeed * Time.deltaTime);

        }
        else
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition, hipFire, aimspeed * Time.deltaTime);
        }
    }
}
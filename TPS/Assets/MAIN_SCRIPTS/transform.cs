using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    
    public Transform transformofGun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transformofGun.position;
        transform.rotation = transformofGun.rotation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammo : MonoBehaviour
{

    public GameObject Guns;
    public Text score; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = Guns.GetComponentInChildren<Guns>().currentAmmo.ToString();
    }
}

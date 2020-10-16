using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject weapon;
    [SerializeField] Transform hand;

    void Start()
    {
        weapon.transform.SetParent(hand);
    }

}

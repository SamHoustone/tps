using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIM : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset;

    Animator anim;
    Transform chest;

    private void Start()
    {
        anim = GetComponent<Animator>();
        chest = anim.GetBoneTransform(HumanBodyBones.Chest);

    }


    private void LateUpdate()
    {
        chest.LookAt(Target.position);
        chest.rotation = chest.rotation * Quaternion.Euler(offset);
    }


}

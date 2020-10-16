using UnityEngine;

public class IK : MonoBehaviour
{

    float RightHand = 1;
    float LeftHand = 1;
    float RightHandPos = 0;
    public Vector3 HandOffset;
    public Vector3 AimSightPosition = new Vector3(0.02f, 0.19f, 0.02f);

    [SerializeField] Transform Target;
    [SerializeField] GameObject leftHand;
    [SerializeField] GameObject rightHand;
    Transform HeadTrans;
    [SerializeField] Animator anim;

    void Start()
    {

        HeadTrans = anim.GetBoneTransform(HumanBodyBones.Head);
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (layerIndex == 1)
        {
            anim.SetIKRotation(AvatarIKGoal.LeftHand, leftHand.transform.rotation);
            anim.SetIKPosition(AvatarIKGoal.LeftHand, leftHand.transform.position);
        }
    }
}
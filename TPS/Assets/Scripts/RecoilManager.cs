using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoilManager : MonoBehaviour
{
    [System.Serializable]
    public struct Layer
    {
        public AnimationCurve curve;
        public Vector3 direction;
    }

    [SerializeField] Layer[] layers;
    [SerializeField] float recoilSpeed;
    [SerializeField] float recoilCooldown;
    [SerializeField] float strength;
    public Guns guns;
    [SerializeField] Crosshair crosshair;

    float nextRecoilCooldown;
    float recoilActiveTime;

    public void Activate()
    {
        nextRecoilCooldown = Time.time + recoilCooldown;
    }

    void Update()
    {
        if (nextRecoilCooldown > Time.time)
        {
            recoilActiveTime += Time.deltaTime;
            float percentage = getPercentage();

            Vector3 recoilAmount = Vector3.zero;
            for (int i = 0; i < layers.Length; i++)
                recoilAmount += layers[i].direction * layers[i].curve.Evaluate(percentage);

            guns.aimTargetOffset = Vector3.Lerp(guns.aimTargetOffset, guns.aimTargetOffset + recoilAmount, strength * Time.deltaTime);
            crosshair.ApplyScale(percentage * Random.Range(strength * 7, strength * 9));
        }
        else
        {
            recoilActiveTime -= Time.deltaTime;
            if (recoilActiveTime < 0)
                recoilActiveTime = 0;

            crosshair.ApplyScale(getPercentage());

            if (recoilActiveTime == 0)
            {
                guns.aimTargetOffset = Vector3.zero;
                crosshair.ApplyScale(0);
            }
        }
    }

    float getPercentage()
    {
        float percentage = recoilActiveTime / recoilSpeed;
        return Mathf.Clamp01(percentage);
    }
}

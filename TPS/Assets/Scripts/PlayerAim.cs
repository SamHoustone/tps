using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    [SerializeField] float minX;
    [SerializeField] float maxX;

    public void SetRotation(float amount)
    {
        transform.eulerAngles = new Vector3(getClampedAngle(amount), transform.eulerAngles.y, transform.eulerAngles.z);
    }

    float getClampedAngle(float amount)
    {
        float newAngle = transform.eulerAngles.x - amount;
        float clampAngle = Mathf.Clamp(newAngle, minX, maxX);
        return clampAngle;
    }

    public float GetAngle()
    {
        return CheckAngle(transform.eulerAngles.x);
    }

    public float CheckAngle(float value)
    {
        float angle = value - 180;
        if (angle > 0)
            return angle - 180;
        return angle + 180;
    }
}
using UnityEngine;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] Transform crosshair;
    [SerializeField] Transform top, botton, left, right;


    float startPoint;

    void Start()
    {
        startPoint = top.localPosition.y;
    }

    void Update()
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        crosshair.transform.position = Vector3.Lerp(crosshair.transform.position, screenPosition, speed * Time.deltaTime);
    }

    public void ApplyScale(float scale)
    {
        top.localPosition = new Vector3(0, startPoint + scale, 0);
        botton.localPosition = new Vector3(0, -startPoint - scale, 0);
        left.localPosition = new Vector3(-startPoint - scale, 0);
        right.localPosition = new Vector3(startPoint + scale, 0, 0);
    }
}
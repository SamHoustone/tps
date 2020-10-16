using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    [System.Serializable]
    public class Cam
    {
        public Vector3 offset;
        public float crouchHeight;
        public float damping;
    }

    [SerializeField] Player player;
    [SerializeField] Transform target;
    [SerializeField] Cam normalCamera;
    [SerializeField] Cam aimCamera;

    void Update()
    {
        Cam data = normalCamera;
        if (player.isAiming) 
            data = aimCamera;

        float targetHeight = data.offset.y + (player.isCrouching ? data.crouchHeight : 0);

        Vector3 targetPosition = target.position + player.transform.forward * data.offset.z + player.transform.up * targetHeight + player.transform.right * data.offset.x;

        Vector3 collisionCheckEnd = target.position + player.transform.up * targetHeight - player.transform.forward * .5f;

        RaycastHit hit;
        if (Physics.Linecast(collisionCheckEnd, targetPosition, out hit))
        {
            Vector3 hitPoint = new Vector3(hit.point.x + hit.normal.x * .2f, hit.point.y, hit.point.z + hit.normal.z * .2f);
            targetPosition = new Vector3(hitPoint.x, targetPosition.y, hitPoint.z);
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, data.damping * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, data.damping * Time.deltaTime);
    }
}
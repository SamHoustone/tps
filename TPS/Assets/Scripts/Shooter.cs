using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform muzzle;
    [SerializeField] GameObject projectile;
    [SerializeField] Transform aimTarget;
    [SerializeField] ParticleSystem particles;
    [SerializeField] RecoilManager recoil;

    [HideInInspector] public Vector3 aimTargetOffset = Vector3.zero;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            muzzle.LookAt(aimTarget.position + aimTargetOffset);
            particles.Play();
            Projectile bullet = Instantiate(projectile, muzzle.position, muzzle.rotation).GetComponent<Projectile>();

            Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
            RaycastHit hit;
            Vector3 targetPosition = ray.GetPoint(500);

            if (Physics.Raycast(ray, out hit))
                targetPosition = hit.point;

            bullet.transform.LookAt(targetPosition + aimTargetOffset);

            recoil.Activate();
        }
    }
}
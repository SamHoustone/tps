using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float timeToLive;
    [SerializeField] float damage;
    [SerializeField] GameObject bulletHole;



    Vector3 destination = Vector3.zero;

    void Start()
    {
        Destroy(gameObject, timeToLive);
    }

    void Update()
    {
        if (destinationReached())
        {
            Destroy(gameObject);
            return;
        }
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
            
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (destination != Vector3.zero)
                return;
       
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            Debug.Log("Hit: " + hit.transform.name);
            destination = hit.point + hit.normal * .0015f;
            Destroy(Instantiate(bulletHole, destination, Quaternion.LookRotation(hit.normal) * Quaternion.Euler(0, 180f, 0), hit.transform), 10f);
        }
    }

    bool destinationReached()
    {
        if (destination == Vector3.zero)
            return false;

        Vector3 directionToDestination = destination - transform.position;
        float dot = Vector3.Dot(directionToDestination, transform.forward);

        return dot < 0;
    }
   void Shoot ()
    {

    }
}
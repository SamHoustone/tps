using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Guns : MonoBehaviour 
{
    public float damage = 10f;
    public float range = 100f;
    public GameObject shootpoint;

    public InputManager inputManager;

    public GameObject cam1;
    public GameObject cam2;

    public float fireRate;
    float intervalBetweenShots;

    public ParticleSystem gun_Flash;

    [SerializeField] GameObject projectile;
    public Vector3 aimTargetOffset;

    public int maxAmmo = 30;
     public int currentAmmo = -1;

    public AimDownSight aimDownSight;

    public float reloadTime;
    public bool isReloading = false;

    public Animator animator;
    public GameObject ammo;

    public Recoil recoil;
    public Recoil aimRecoil;
   
    void Start()
    {   if(currentAmmo == -1)
        currentAmmo = maxAmmo;
    }

   
    void Update()
    {
        if (isReloading)
            return;

        if (currentAmmo != maxAmmo)
        {
            if (Input.GetKeyDown(KeyCode.R))
                StartCoroutine(Reload());
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if (Input.GetButton("Fire1") && Time.time >= intervalBetweenShots)
        {
            intervalBetweenShots = Time.time + 1f / fireRate;
            Shoot();
        }
        IEnumerator Reload()
        {
            isReloading = true;

            aimDownSight.cam1.GetComponent<Camera>().enabled = true;
            cam2.SetActive(false);
            animator.SetBool("reload", true);
            aimDownSight.cam1.GetComponent<Camera>().enabled = true;
            yield return new WaitForSeconds(reloadTime);
            animator.SetBool("reload", false);
            aimDownSight.crosshair.enabled = true;


            currentAmmo = maxAmmo;
            isReloading = false;

            if (Input.GetMouseButtonDown(1))
            {
                aimDownSight.cam1.GetComponent<Camera>().enabled = false;
                cam2.SetActive(true);
            }
        }

        void Shoot ()
        {
            recoil.HipRecoil();
            
            currentAmmo--;

            GameObject go = Instantiate(projectile, shootpoint.transform.position, shootpoint.transform.rotation);

            Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
            RaycastHit hit;
            Vector3 targetPosition = ray.GetPoint(500);
            

            if (Physics.Raycast(ray, out hit))
                targetPosition = hit.point;

            

            gun_Flash.Play();
        }

        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper_Scope : MonoBehaviour
{
    public float Scopedview = 15f;
    public float normalview;

    bool is_Scoped = false;

    public Camera mainCamera;

    public GameObject scopeOverlay;

    public GameObject Sniper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnDisable()
    {
        Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
            Enable();
        if (Input.GetButtonUp("Fire2"))
            Disable();
    }

    public void Enable()
    {
        scopeOverlay.SetActive(true);
        mainCamera.fieldOfView = Scopedview;
    }
    public void Disable()
    {
        scopeOverlay.SetActive(false);
        mainCamera.fieldOfView = normalview;
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]
    public class MouseInput
    {
        public Vector2 Damping;
        public Vector2 Sensitivity;
    }

    [SerializeField] InputController input;
    [SerializeField] MovementController controller;
    [SerializeField] Animator anim;
    [SerializeField] float speed;
    [SerializeField] MouseInput mouseControl;
    [SerializeField] Crosshair crosshair;
    [SerializeField] PlayerAim aim;

    Vector2 mouseInput;
    public bool isAiming { get { return input.IsAiming; } }

    Rigidbody[]  bodyParts;

    public bool isCrouching { get { return input.Crouch; } }

    void Start()
    {
        bodyParts = GetComponentsInChildren<Rigidbody>();
    }

    public void UpdateRagdoll(bool value)
    {
        if (value) anim.enabled = false;
        else anim.enabled = true;

        foreach (var b in bodyParts)
            b.isKinematic = !value;
    }

    void Update()
    {
        Vector2 direction = new Vector2(input.Vertical * speed, input.Horizontal * speed);
        controller.Move(direction);

        mouseInput.x = Mathf.Lerp(mouseInput.x, input.MouseInput.x, 1f / mouseControl.Damping.x);
        mouseInput.y = Mathf.Lerp(mouseInput.y, input.MouseInput.y, 1f / mouseControl.Damping.y);

        transform.Rotate(Vector3.up * mouseInput.x * mouseControl.Sensitivity.x);
        aim.SetRotation(mouseInput.y * mouseControl.Sensitivity.y);

        if (input.Reload)
            anim.Play("Reload");

        anim.SetBool("Crouch", input.Crouch);
        anim.SetFloat("Horizontal", input.Horizontal);
        anim.SetFloat("Vertical", input.Vertical);

        anim.SetFloat("AimAngle", -aim.GetAngle());
        anim.SetBool("IsAiming", isAiming);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] string vertical_axis = "Vertical";
    [SerializeField] string horizontal_axis = "Horizontal";
    [SerializeField] string mouse_x_axis = "Mouse X";
    [SerializeField] string mouse_y_axis = "Mouse Y";
    [SerializeField] KeyCode crouchKeyCode = KeyCode.LeftControl;
    [SerializeField] string mouse_wheel_axis = "Mouse ScrollWheel";
    [SerializeField] int aiming_mouse_key = 1;
    [SerializeField] KeyCode reloadKeyCode = KeyCode.R;

    public float Vertical { get; private set; }
    public float Horizontal { get; private set; }
    public Vector2 MouseInput { get; private set; }
    public bool Crouch { get; private set; }
    public bool MouseWheelUp { get; private set; }
    public bool MouseWheelDown { get; private set; }
    public bool IsAiming { get; private set; }
    public bool Reload { get; private set; }

    void Update()
    {
        Vertical = Input.GetAxis(vertical_axis);
        Horizontal = Input.GetAxis(horizontal_axis);
        MouseInput = new Vector2(Input.GetAxisRaw(mouse_x_axis), Input.GetAxisRaw(mouse_y_axis));
        Crouch = Input.GetKey(crouchKeyCode);
        MouseWheelUp = Input.GetAxis(mouse_wheel_axis) > 0;
        MouseWheelDown = Input.GetAxis(mouse_wheel_axis) < 0;
        if (Input.GetMouseButtonDown(aiming_mouse_key))
            IsAiming = true;
        else if (Input.GetMouseButtonUp(aiming_mouse_key))
            IsAiming = false;
        Reload = Input.GetKeyDown(reloadKeyCode);
    }
}

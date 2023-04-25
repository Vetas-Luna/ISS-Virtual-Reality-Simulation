using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class ClimbProvider : MonoBehaviour
{
    public static event Action ClimbActive;
    public static event Action ClimbInactive;

    public CharacterController characterController;
    public InputActionProperty velocityRight;
    public InputActionProperty velocityLeft;

    public Rigidbody characterRB;
    private bool _rightActive = false;
    private bool _leftActive = false;

    private void Start()
    {
        XRDirectClimbInteractor.ClimbHandActivated += HandActivated;
        XRDirectClimbInteractor.ClimbHandDeactivated += HandDeactivated;
    }

    private void OnDestroy()
    {
        XRDirectClimbInteractor.ClimbHandActivated -= HandActivated;
        XRDirectClimbInteractor.ClimbHandDeactivated -= HandDeactivated;
    }

    private void HandActivated(string _controllerName)
    {
        if(_controllerName == "Left Climb Interactor")
        {
            _leftActive = true;
            _rightActive = false;
        }
        else
        {
            _leftActive = false;
            _rightActive = true;
        }

        ClimbActive?.Invoke();
    }

    private void HandDeactivated(string _controllerName)
    {
        Vector3 velocity = _leftActive ? velocityLeft.action.ReadValue<Vector3>() : velocityRight.action.ReadValue<Vector3>();
        if (_rightActive && _controllerName == "Right Climb Interactor")
        {
            _rightActive = false;
            Release(-velocity);
            ClimbInactive?.Invoke();
        }
        else if (_leftActive && _controllerName == "Left Climb Interactor")
        {
            _leftActive = false;
            Release(-velocity);
            ClimbInactive?.Invoke();

        }
    }

    private void FixedUpdate()
    {
        if (_rightActive || _leftActive)
        {
            Climb();
        }
    }

    private void Climb()
    {
        Vector3 velocity = _leftActive ? velocityLeft.action.ReadValue<Vector3>() : velocityRight.action.ReadValue<Vector3>();

        characterRB.velocity = -velocity;
    }

    private void Release(Vector3 ctrlVelocity)
    {
        characterRB.velocity = ctrlVelocity; 
    }
}

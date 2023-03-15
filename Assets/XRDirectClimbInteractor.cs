using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class XRDirectClimbInteractor : XRDirectInteractor
{
    public static event Action<string> ClimbHandActivated;
    public static event Action<string> ClimbHandDeactivated;
    public InputActionProperty velocity;

    private string _controllerName;

    protected override void Start()
    {
        base.Start();
        _controllerName = gameObject.name;
    }

    void Update()
    {
        //Debug.Log(velocity.action.ReadValue<Vector3>());
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        Debug.Log("Selected\n");
        if(args.interactableObject.transform.gameObject.tag == "Climb")
        {
            Debug.Log("Active!\n");
            ClimbHandActivated?.Invoke(_controllerName);
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        ClimbHandDeactivated?.Invoke(_controllerName);
    }
}

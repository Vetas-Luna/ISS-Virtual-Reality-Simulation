using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerGravity : MonoBehaviour
{
    private CharacterController _characterController;
    private bool _climbing = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        ClimbProvider.ClimbActive += ClimbActive;
        ClimbProvider.ClimbInactive += ClimbInactive;
    }

    private void OnDestroy()
    {
        ClimbProvider.ClimbActive -= ClimbActive;
        ClimbProvider.ClimbInactive -= ClimbInactive;

    }

    void FixedUpdate()
    {
        if (!_characterController.isGrounded && !_climbing)
        {
            _characterController.SimpleMove(new Vector3());
        }
    }

    private void ClimbActive()
    {
        _climbing = true;
    }

    private void ClimbInactive()
    {
        _climbing = false;
    }
}

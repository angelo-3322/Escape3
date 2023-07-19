using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    [SerializeField]
    float thrusterForce = 650.0F;

    [SerializeField]
    float rotationSpeed = 25.0F;

    Rigidbody _rb;

    bool _isthrusterPressed;

    float _inputX;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HandleInputs();
    }

    void FixedUpdate()
    {
        HandleRotation();
        HandleThruster();
    }

    void HandleRotation()
    {
        if (!_isthrusterPressed)
        {
            return;
        }

        Vector3 rotation = Vector3.forward * -_inputX * rotationSpeed * Time.fixedDeltaTime;
        transform.Rotate(rotation);
    }

    void HandleThruster()
    {
        if (!_isthrusterPressed)
        {
            return;
        }

        Vector3 direction = Vector3.up * thrusterForce * Time.fixedDeltaTime;
        _rb.AddRelativeForce(direction, ForceMode.Force);
    }

    void HandleInputs()
    {
        _inputX = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            _isthrusterPressed = true;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            _isthrusterPressed = false;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField]
    Vector3 rotation;

    [SerializeField]
    float speed;

     void Start()
    {
        rotation = rotation.normalized;
    }

     void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime);
    }
}

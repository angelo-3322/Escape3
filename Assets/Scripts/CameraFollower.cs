using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    float smoothTransitionTime = 0.15F;

    Vector3 offset;
    Vector3 zero = Vector3.zero;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        transform.position =
            Vector3.SmoothDamp(transform.position, target.position + offset, ref zero, smoothTransitionTime * Time.deltaTime);
    }

}

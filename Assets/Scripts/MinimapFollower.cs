using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapFollower : MonoBehaviour
{
    [SerializeField]
    Transform target;

    private void LateUpdate()
    {
        Vector3 position = target.position;
        position.y = transform.position.y;
        transform.position = position;
    }
}

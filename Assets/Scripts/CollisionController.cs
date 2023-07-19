using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.CompareTag("UFO") || other.gameObject.CompareTag("Edge"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

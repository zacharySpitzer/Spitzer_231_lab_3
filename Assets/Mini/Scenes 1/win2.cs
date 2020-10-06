using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win2 : MonoBehaviour
{
    SceneManager scene;
    public void OnTriggerEnter(Collider other)
    {

        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        if (rb)
        {
            
            SceneManager.LoadScene(1);
        }

    }
}

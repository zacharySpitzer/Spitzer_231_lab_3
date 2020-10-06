using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class WIn : MonoBehaviour
{
    ChangeScene scene;
    public Text txt;

    public void OnTriggerEnter(Collider other)
    {

        touchBeh SB = other.gameObject.GetComponent<touchBeh>();
        if (SB)
        {
            txt.text = "you win congrats";
            SceneManager.LoadScene(3);
        }
   
    }
}

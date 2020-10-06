using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class Manager : MonoBehaviour
{
    public GameObject ye;
    public ARPlaneManager planeAr;
    

    private void Awake()
    {
       
    }
    public void GetAllPlanes(List<ARPlane> planes)
    {

    }
    public void reee(bool value)
    {
        foreach (var plane in planeAr.trackables)
            plane.gameObject.SetActive(value);
        planeAr.enabled = !planeAr.enabled;
    }
}

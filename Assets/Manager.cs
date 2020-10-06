using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Vector3 scales;
    public Slider rot;
    public Slider scale;
    public GameObject kyle;
   
    private void Start()
    {
        rot.maxValue = 360;
        rot.minValue = 0;
        scale.maxValue = 5;
        scale.minValue = 0;
    }
    void Update()
    { 
        kyle.transform.rotation =Quaternion.Euler(0, rot.value, 0);
        kyle.transform.localScale = new Vector3(scale.value, scale.value, scale.value);
    }
}

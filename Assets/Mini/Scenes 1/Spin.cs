using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
	public Vector3 SpinRatio = Vector3.zero;

	Transform trans;



	// Use this for initialization
	void Start()
	{

		trans = gameObject.transform;


	}

	// Update is called once per frame
	void Update()
	{

		trans.Rotate(SpinRatio * Time.deltaTime);
	}
}

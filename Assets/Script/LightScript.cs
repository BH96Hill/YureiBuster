using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{

	//以下2つ必須
	public GameObject slight;
	float LIntensity;

	// Use this for initialization
	void Start()
	{
		LIntensity = slight.GetComponent<Light>().range;

	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.U))
        {
			//ライトの明るさ
			LIntensity+=0.05f;
			slight.GetComponent<Light>().range = LIntensity;
		}
		if (Input.GetKey(KeyCode.J))
		{
			//ライトの明るさ
			LIntensity-=0.05f;
			slight.GetComponent<Light>().range = LIntensity;
		}


	}
}
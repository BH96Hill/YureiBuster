using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{

	//�ȉ�2�K�{
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
			//���C�g�̖��邳
			LIntensity+=0.05f;
			slight.GetComponent<Light>().range = LIntensity;
		}
		if (Input.GetKey(KeyCode.J))
		{
			//���C�g�̖��邳
			LIntensity-=0.05f;
			slight.GetComponent<Light>().range = LIntensity;
		}


	}
}
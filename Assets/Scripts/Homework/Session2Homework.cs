using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Session2Homework : MonoBehaviour {
	// Use this for initialization

	public string poet = "Less is more";
	public float[] somefigures = { 1.24f, 3, 1.255f, 6 };

	void Start()

	{

		for (int i = 0; i <= poet.Length; i++)
		{
			char letter = poet[i];
			Debug.LogFormat("'{0}';{1}", letter, char.GetUnicodeCategory(letter));
		
		}
			

		foreach( float figure in somefigures)
        {
			Debug.Log("CurrentFigure: " + figure.ToString());
			if (figure.ToString().Contains("."))
			{
				Debug.Log(figure.ToString() + ": This figure is a float variable.");
			}
			else
			{
				Debug.Log(figure.ToString() + ": This figure is a int variable.");
			}
        }


	}





		
	// Update is called once per frame
	void Update () {
		
	}
}

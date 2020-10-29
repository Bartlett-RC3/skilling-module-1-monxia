using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using JetBrains.Annotations;
using UnityEngine;

public class Session1Homework : MonoBehaviour {
	Dictionary<string, string> ComponentTypes = new Dictionary<string, string>();
	// Use this for initialization
	public string intro = " Hi, My name is Meng Xia...";
	public int JewelleryQty = 15;
	public float WeightPerPcs = 194.55f;

	public int[] InitialDimensions = new int[3];
	public float[] MorePreceisely = {115.25f, 113.35f, 116.5f};

	public List<string> MyReadingList = new List<string>();

	private float Calculator(int _Qty, float _Weight)
	{
		float Result = _Qty * _Weight;
		return Result;
	}
		
		

	void Start () {

		float Result = Calculator(JewelleryQty, WeightPerPcs);
		Debug.Log(" The total weight(in g) of the package is " + Result.ToString());
		ComponentTypes["TypeA"] = "Sqaure";
		ComponentTypes["TypeB"] = "Triangle";
		ComponentTypes["TypeC"] = "Circle";

		Debug.Log(message: $"{ComponentTypes["TypeA"]}" + " Belongs to TypeA");
		Debug.Log(message: $"{ComponentTypes["TypeB"]}" + " Belongs to TypeB");
		Debug.Log(message: $"{ComponentTypes["TypeC"]}" + " Belongs to TypeC");
	}
	
	
}


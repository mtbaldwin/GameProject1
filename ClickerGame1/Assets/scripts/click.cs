using UnityEngine;
using System.Collections;

public class click : MonoBehaviour{
	public static int count =0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown (){
		count += 1;
		Debug.Log (count);
	}
}

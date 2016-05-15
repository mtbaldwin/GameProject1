using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public int health;
	public string type;
	public int timer;
	public int level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int getHealth(){
		return this.health;
	}
	string getType(){
		return this.type;
	}

	void onDefeat(){

	}
}

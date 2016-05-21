using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public int health= 1000;
	public string type;
	public int timer;
	public int level;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	
	}
	public void damageHealth(int damage){
		health = health - damage;

		if (health < 0) {
			onDefeat ();
		}
		Debug.Log (health);
	}
	public int getHealth(){
		return this.health;
	}
	public string getType(){
		return this.type;
	}

	void onDefeat(){
		Debug.Log ("Enemy Dead");
	}


}

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int level =5;
	public int damage =5;
	//public Weapon weapon;
	public ArrayList perks;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void setDamage(int damage){
		this.damage = damage;
	}
	void setLevel(int level){
		this.level = level;
	}
	public int getAttack(){
		return level * (damage);
	}
	//returns previous weapon 
	//Weapon changeWeapon(Weapon weapon){
	//	Weapon foo = this.weapon;
	//	this.weapon = weapon;
	//	return foo;
	//}


}

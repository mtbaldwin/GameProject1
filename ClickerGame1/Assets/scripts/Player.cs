using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int level =5;
	public int experience =98;
	public int damage =5;
	//public Weapon weapon;
	public ArrayList perks;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setDamage(int damage){
		this.damage = damage;
	}
	public void setLevel(int level){
		this.level = level;
	}
	public void incrementLevel(){
		level++;
	}
	public int getAttack(){
		
		addExperience (20);
		return level * (damage);
	}
	public void addExperience(int experience){
		this.experience = this.experience + experience;
	}
	public void setExperience(int experience){
		this.experience = experience;
	}
	public int getExperience(){
		return experience;
	}
	//returns previous weapon 
	//Weapon changeWeapon(Weapon weapon){
	//	Weapon foo = this.weapon;
	//	this.weapon = weapon;
	//	return foo;
	//}


}

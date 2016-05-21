using UnityEngine;
using System.Collections;

public class click : MonoBehaviour{
	public GameObject driver;
	public Player player;
	public Enemy enemy;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		player = driver.GetComponent<Driver>().getPlayer();
		if (player.getExperience() >= 100) {
			player.incrementLevel ();
			player.setExperience (player.getExperience () - 100);
		}
	}

	public void OnMouseDown (){
		
		player = driver.GetComponent<Driver>().getPlayer();
		enemy = driver.GetComponent<Driver>().getEnemy();
		Debug.Log (player.getAttack());
		enemy.damageHealth (player.getAttack ());


	}


}

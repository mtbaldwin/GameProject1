using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {
	public Player player;
	public Enemy enemy;


	// Use this for initialization
	void Awake () {
		player = new Player();
		enemy = new Enemy ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public Player getPlayer(){
		return this.player;
	}
	public Enemy getEnemy(){
		return this.enemy;
	}


}
using UnityEngine;
using System.Collections;

public class click : MonoBehaviour{
	public GameObject driver;
	public Player player;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseDown (){
		player = driver.GetComponent<Driver>().getPlayer();
		Debug.Log (player.getAttack());

	}
	public void attackEnemy(Player player, Enemy ememy){
		
	}

}

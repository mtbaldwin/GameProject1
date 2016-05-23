using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.UI;

public class clicktemp : MonoBehaviour{
	public GameObject driver;
    public Image HPbar;
	public Player player;
	public Enemy enemy;

	//public Image HPbar;
	public float fillamount;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		enemy = driver.GetComponent<Driver>().getEnemy();
		player = driver.GetComponent<Driver>().getPlayer();
		updateBar ();
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

	public void updateBar(){
		fillamount = (enemy.getHealth() / enemy.getStartingHealth());
        HPbar.fillAmount = fillamount;
	}

    

}

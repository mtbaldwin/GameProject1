using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float health= 1000;
    public float startingHealth = 1000;
	public string type;
	public int timer;
	public int level;

    public float enemyChange;
    public Renderer rend;
    public Material current;
    public Material  testOne;
    public Material  testTwo;
    public Material  testThree;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
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
	public float getHealth(){
		return this.health;
	}
	public string getType(){
		return this.type;
	}

	public void onDefeat(){
		Debug.Log ("Enemy Dead");
        health = 1000;
        startingHealth = 1000;
        enemyChange = (int)Random.Range(1.0F, 3.9999F);
        Debug.Log(enemyChange);
        if (enemyChange == 1)
        {
           
            Debug.Log("Mat1");
        }
        if (enemyChange == 2)
        {
            
            Debug.Log("Mat2");
        }
        if (enemyChange == 3)
        {
            
         
            Debug.Log("Mat3");
        }

    }

    public float getStartingHealth()
    {
        return startingHealth;
    }

}

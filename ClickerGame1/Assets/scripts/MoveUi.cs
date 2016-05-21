using UnityEngine;
using System.Collections;

public class MoveUi : MonoBehaviour {
	public GameObject inventory;
	public GameObject support;
	public GameObject hero;
	public GameObject chest;
	public GameObject mail;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnMouseDown (){
		Debug.Log ("move");
		inventory.transform.position = new Vector3 (-50, -50, -50);
		support.transform.position = new Vector3 (-50, -50, -50);
		hero.transform.position = new Vector3 (-50, -50, -50);
		chest.transform.position = new Vector3 (-50, -50, -50);
		mail.transform.position = new Vector3 (-50, -50, -50);
	}
}

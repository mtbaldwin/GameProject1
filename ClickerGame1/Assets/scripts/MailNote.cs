using UnityEngine;
using System.Collections;

public class MailNote : MonoBehaviour {
	public GameObject note;
	public bool active;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		note.SetActive(active);
	}
}

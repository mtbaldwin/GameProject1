using UnityEngine;
using System.Collections;

public class ForceLandscape : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

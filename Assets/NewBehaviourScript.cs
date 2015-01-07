using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {

		GUI.Label (new Rect (250, 70, 100, 20), "This is Scene 1");
		if (GUI.Button (new Rect (250, 100, 100, 25), "Go to Scene 2"))
			Application.LoadLevel ("Scene 2");

		#if CLOUD_BUILD

			GUI.Label(new Rect(10,10,225,20), "This ad has been brought to you by the people at CloudBuild.");

		#endif

		#if SCRIPT_DEFINE

			GUI.Label(new Rect(10,40,225,20), "You have defined this to fire.");
		
		#endif

		#if UNITY_IOS

			GUI.Label(new Rect(10,60,225,20), "This is an iOS build.");
		
		#endif

		#if UNITY_ANDROID

			GUI.Label(new Rect(10,80,225,20), "This is an Android build.");

		#endif

		#if UNITY_WEBPLAYER

			GUI.Label(new Rect(10,100,225,20), "This is a Webplayer build.");
		
		#endif

	
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}

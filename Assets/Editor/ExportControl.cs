using UnityEngine;
using UnityEditor;
using System.Collections;

public class ExportControl : MonoBehaviour {

	string path;
	
	public static void PreExportMethod () {
		
		Debug.Log("******THE PREEXPORT TOOL WORKS!!******");
		
	}
	
	public static void PreExportMethod (string path) {
		
		Debug.Log("******THE POSTEXPORT TOOL WORKS!!******");
		
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class Cubespin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Rotate (1, 1, 0, Space.World);
	
	}
}

using UnityEngine;
using System.Collections;

public class retry : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Retry(){
		Application.LoadLevel ("map1");
	}
}

using UnityEngine;
using System.Collections;

public class start_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void start()
    {
        Application.LoadLevel("two");
    }
}

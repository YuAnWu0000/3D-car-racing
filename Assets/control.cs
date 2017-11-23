using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class control : MonoBehaviour {
    private Rigidbody car;
	// Use this for initialization
	void Start () {
        car = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            car.transform.Translate(Vector3.right);
            //car.velocity=Vector3.right * 10;
        }
        if (Input.GetKey(KeyCode.A))
        {
            car.transform.Translate(Vector3.forward);
            //car.velocity=Vector3.forward * 10;
        }
        if (Input.GetKey(KeyCode.S))
        {
            car.transform.Translate(Vector3.left);
            //car.velocity=Vector3.left * 10;
        }
        if (Input.GetKey(KeyCode.D))
        {
            car.transform.Translate(Vector3.back);
            //car.velocity=Vector3.back * 10;
        }
    }
}

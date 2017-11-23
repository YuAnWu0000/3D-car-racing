using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour {

    public static float timer_f = 0f;
    int timer_a = 0;
    int timer_b = 0;
    int timer_c = 0;

    Text t;

    // Use this for initialization
    void Start () {

        t = GameObject.Find("Canvas/time").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        timer_f += Time.deltaTime*100f;

        t.text = ((int)timer_f/6000).ToString() + ":" + ( ((int)timer_f %6000) / 100).ToString() + ":" + ((int)timer_f % 100).ToString();
	}
}

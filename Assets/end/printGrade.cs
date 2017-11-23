using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class printGrade : MonoBehaviour {

    float time = timer.timer_f;
    Text t;
	// Use this for initialization
	void Start () {
        t = GameObject.Find("Canvas/Text").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        t.text = "您的成績：" + ((int)time / 6000).ToString() + ":" + (((int)time % 6000) / 100).ToString() + ":" + ((int)time % 100).ToString();
    }
}

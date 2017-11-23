using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class abc : MonoBehaviour {

    int ci;
    int check;
    Text gci;
    Text gch;
    string s;

    // Use this for initialization
    void Start () {

        ci = 0;
        check = 0;

        gci = GameObject.Find("Canvas/count").GetComponent<Text>();
        gch = GameObject.Find("Canvas/check").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "123")
        {

            Destroy(other.gameObject);

            check++;

            if (check > 8)
            {
                ci++;
                check = 0;
            }

            gci.text = "第" + ci.ToString() + "/1圈";
            gch.text = check.ToString() + "/9檢查點";

            if(ci == 1) {
				Application.LoadLevel("end");
            }

            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float time;

    private GameObject secondText;

	// Use this for initialization
	void Start () {
        time = 0;
        secondText = gameObject.transform.Find("second").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        secondText.GetComponent<Text>().text = time.ToString("f2");
	}
}

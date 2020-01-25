using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour {

    public GameObject light_1;
    public GameObject light_2;
    public GameObject light_3;
    public GameObject light_4;
    public float lightTime;
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        GetComponent<AudioSource> ().Play ();
        lightTime = Time.realtimeSinceStartup;
        if (lightTime >= 10f & lightTime <=30f) {
            light_1.SetActive(false);
            light_2.SetActive(false);
            light_3.SetActive(false);
            light_4.SetActive(false);
        }
        if (lightTime >= 30f) {
            light_1.SetActive(true);
            light_2.SetActive(true);
            light_3.SetActive(true);
            light_4.SetActive(true);
            lightTime = 0f;
        }
	}
}

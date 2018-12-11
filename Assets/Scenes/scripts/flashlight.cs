using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour {

    // Use this for initialization
	// Update is called once per frame
	void Update () {
        GetComponent<Light>().intensity -= .01f;
        if(GetComponent<Light>().intensity <= 0)
        {
            GetComponent<Light>().intensity = 0;
        }
    }
}

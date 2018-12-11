using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trigger_class : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(JumpScare());
        }
    }

    public abstract IEnumerator JumpScare();

}

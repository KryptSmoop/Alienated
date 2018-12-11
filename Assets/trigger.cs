using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : Trigger_class {

    // Use this for initialization

    public GameObject scare;

    public override IEnumerator JumpScare()
    {
        scare.SetActive(true);
        yield return new WaitForSeconds(2);
        scare.SetActive(false);
        transform.gameObject.SetActive(false);
    }

}

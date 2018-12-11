using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger2 : Trigger_class {

    // Use this for initialization

    public Animator dooranim;

    public GameObject jumpscare;

    public override IEnumerator JumpScare()
    {
        dooranim.SetBool("open_door", true);
        yield return new WaitForSeconds(2);
        jumpscare.SetActive(true);
        yield return new WaitForSeconds(2);
        jumpscare.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_move : MonoBehaviour {

    // Use this for initialization

    AudioSource audio_src;
    Animator anim;

    public void Start()
    {
        audio_src = GetComponent<AudioSource>();

        anim = GetComponent<Animator>();
    }

	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("walking", true);
            anim.SetBool("idle", false);
            audio_src.Play(); 
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("walking", false);
            anim.SetBool("idle", true);
            audio_src.Pause();
        }
    }
}

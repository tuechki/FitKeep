using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIsHappy : MonoBehaviour {
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update () {
        if (Character_Stats.getIsHappy())
            anim.SetBool("isHappy", true);
        else anim.SetBool("isHappy", false);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartChange : MonoBehaviour {
    private Animator anim;
    public GameObject body_part;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {
        if (body_part.tag == "Torso")
            anim.SetInteger("howFit", Character_Stats.getBody());

        if (body_part.tag == "Hands")
            anim.SetInteger("howFit", Character_Stats.getHands());

        if (body_part.tag == "Feet")
            anim.SetInteger("howFit", Character_Stats.getLegs());
    }
}

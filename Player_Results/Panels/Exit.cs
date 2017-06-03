using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
    public GameObject Overall;
    public GameObject Body;
    public GameObject Hands;
    public GameObject Legs;
    public GameObject Button;


    public GameObject Chest;
    public GameObject Abs;
    public GameObject Back;

    public GameObject Buttocks;
    public GameObject Thighs;
    public GameObject Calfs;

    public GameObject Biceps;
    public GameObject Triceps;
    public GameObject Forearm;
    public GameObject Shoulder;


    public void Clicked()
    {

        Overall.SetActive(true);
        Body.SetActive(true);
        Hands.SetActive(true);
        Legs.SetActive(true);
        Button.SetActive(false);

        Chest.SetActive(false);
        Back.SetActive(false);
        Abs.SetActive(false);

        Buttocks.SetActive(false);
        Thighs.SetActive(false);
        Calfs.SetActive(false);

        Biceps.SetActive(false);
        Triceps.SetActive(false);
        Forearm.SetActive(false);
        Shoulder.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSubStats : MonoBehaviour {
    public GameObject Overall;
    public GameObject Body;
    public GameObject Hands;
    public GameObject Legs;
    public GameObject Button;

    public GameObject ClickedObject;

   void Click()
    {

        Overall.SetActive(false);
        Body.SetActive(false);
        Hands.SetActive(false);
        Legs.SetActive(false);
        Button.SetActive(true);
    }
    
    public GameObject Chest;
    public GameObject Abs;
    public GameObject Back;

	public void showTorso()
    {
		Click ();

        Chest.SetActive(true);
        Back.SetActive(true);
        Abs.SetActive(true);
    }

    public GameObject Buttocks;
    public GameObject Thighs;
    public GameObject Calfs;

    public void showFeet()
    {
		Click ();

        Buttocks.SetActive(true);
        Thighs.SetActive(true);
        Calfs.SetActive(true);
    }

    public GameObject Biceps;
    public GameObject Triceps;
    public GameObject Forearm;
    public GameObject Shoulder;

	public void showHands()
    {
		Click ();

        Biceps.SetActive(true);
        Triceps.SetActive(true);
        Forearm.SetActive(true);
        Shoulder.SetActive(true);
    }
}

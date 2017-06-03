using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStats : MonoBehaviour {
    public GameObject myTextgameObject;
    Text ourComponent;

    void Start()
    {
        ourComponent = myTextgameObject.GetComponent<Text>();
    }
    private void Update()
    {
        switch (myTextgameObject.tag)
        {
            case "Torso":
                ourComponent.text = PlayerResults.getBodyScore().ToString();
                break;
            case "Feet":
                ourComponent.text = PlayerResults.getLegsScore().ToString();
                break;
            case "Hands":
                ourComponent.text = PlayerResults.getHandsScore().ToString();
                break;
            default:
                ourComponent.text = PlayerResults.getOverall().ToString();
                break;
        }
    }
}

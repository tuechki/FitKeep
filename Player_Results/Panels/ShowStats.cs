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
            case "Abs":
                ourComponent.text = PlayerResults.getAbsScore().ToString();
                break;
            case "Back":
                ourComponent.text = PlayerResults.getBackScore().ToString();
                break;
            case "Chest":
                ourComponent.text = PlayerResults.getChestScore().ToString();
                break;
            case "Biceps":
                ourComponent.text = PlayerResults.getBicepsScore().ToString();
                break;
            case "Triceps":
                ourComponent.text = PlayerResults.getTricepsScore().ToString();
                break;
            case "Forehand":
                ourComponent.text = PlayerResults.getForearmsScore().ToString();
                break;
            case "Shoulders":
                ourComponent.text = PlayerResults.getShoulderScore().ToString();
                break;
            case "Buttocks":
                ourComponent.text = PlayerResults.getButtocksScore().ToString();
                break;
            case "Thighs":
                ourComponent.text = PlayerResults.getThighsScore().ToString();
                break;
            case "Calfs":
                ourComponent.text = PlayerResults.getCalfScore().ToString();
                break;
            default:
                ourComponent.text = PlayerResults.getOverall().ToString();
                break;
        }
    }
}

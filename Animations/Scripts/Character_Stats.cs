using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Stats : MonoBehaviour {

    public static int Body = 0;
    public static int Hands = 0;
    public static int Legs = 0;
    public static bool isHappy = false;

    //Getters------------------------------------------------------------
    public static int getBody()
    {
        return Body;
    }
    public static int getHands()
    {
        return Hands;
    }
    public static int getLegs()
    {
        return Legs;
    }
    public static bool getIsHappy()
    {
        return isHappy;
    }
    //Setters------------------------------------------------------------
    public static void setBody(int value)
    {
        Body = value;
    }
    public static void setHands(int value)
    {
        Hands = value;
    }
    public static void setLegs(int value)
    {
        Legs = value;
    }
    public static void setIntelligence(bool value)
    {
        isHappy = value;
    }
    //-------------------------------------------------------------------
}

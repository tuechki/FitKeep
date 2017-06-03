using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResults : MonoBehaviour {
    public int Treshhold;
    public static int Overall = 0;
    //Torso
    public static int Body_Score = 0;
    public static int Abs_Score = 0;
    public static int Back_Score = 0;
    public static int Chest_Score = 0;
    //Hands
    public static int Hands_Score = 0;
    public static int Forearms_Score = 0;
    public static int Biceps_Score = 0;
    public static int Triceps_Score = 0;
    public static int Shoulder_Score = 0;
    //Feet
    public static int Legs_Score = 0;
    public static int Thighs_Score = 0;
    public static int Calf_Score = 0;
    public static int Buttocks_Score = 0;

    //Getters------------------------------------------------------------
    //Overall
    public static int getOverall()
    {
        return Overall;
    }
    //Torso 
    public static int getBodyScore()
    {
        return Body_Score;
    }
    public static int getAbsScore()
    {
        return Abs_Score;
    }
    public static int getChestScore()
    {
        return Chest_Score;
    }
    public static int getBackScore()
    {
        return Back_Score;
    }
    //Hands
    public static int getHandsScore()
    {
        return Hands_Score;
    }
    public static int getForearmsScore()
    {
        return Forearms_Score;
    }
    public static int getBicepsScore()
    {
        return Biceps_Score;
    }
    public static int getTricepsScore()
    {
        return Triceps_Score;
    }
    public static int getShoulderScore()
    {
        return Shoulder_Score;
    }
    //Feet
    public static int getLegsScore()
    {
        return Legs_Score;
    }
    public static int getButtocksScore()
    {
        return Buttocks_Score;
    }
    public static int getThighsScore()
    {
        return Thighs_Score;
    }
    public static int getCalfScore()
    {
        return Calf_Score;
    }
    //Setters------------------------------------------------------------
    //Overall
    public static void setOverall(int index)
    {
        Overall = index;
    }
    //Torso 
    public static void setBodyScore(int index)
    {
        Body_Score = index;
    }
    public static void setAbsScore(int index)
    {
        Abs_Score = index;
    }
    public static void setChestScore(int index)
    {
        Chest_Score = index;
    }
    public static void setBackScore(int index)
    {
        Back_Score = index;
    }
    
    //Hands
    public static void setHandsScore(int index)
    {
        Hands_Score = index;
    }
    public static void setForearmsScore(int index)
    {
        Forearms_Score = index;
    }
    public static void setBicepsScore(int index)
    {
        Biceps_Score = index;
    }
    public static void setTricepsScore(int index)
    {
        Triceps_Score = index;
    }
    public static void setShoulderScore(int index)
    {
        Shoulder_Score = index;
    }
    //Feet
    public static void setLegsScore(int index)
    {
        Legs_Score = index;
    }
    public static void setButtocksScore(int index)
    {
        Buttocks_Score = index;
    }
    public static void setThighsScore(int index)
    {
        Thighs_Score = index;
    }
    public static void setCalfScore(int index)
    {
        Calf_Score = index;
    }
    //Uppers------------------------------------------------------------
    //Torso 
    public static void upBodyScore(int index)
    {
        Body_Score += index;
    }
    public static void upAbsScore(int index)
    {
        Abs_Score += index;
    }
    public static void upChestScore(int index)
    {
        Chest_Score += index;
    }
    public static void upBackScore(int index)
    {
        Back_Score += index;
    }
    //Hands
    public static void upHandsScore(int index)
    {
        Hands_Score += index;
    }
    public static void upForearmsScore(int index)
    {
        Forearms_Score += index;
    }
    public static void upBicepsScore(int index)
    {
        Biceps_Score += index;
    }
    public static void upTricepsScore(int index)
    {
        Triceps_Score += index;
    }
    public static void upShoulderScore(int index)
    {
        Shoulder_Score += index;
    }
    //Feet
    public static void upLegsScore(int index)
    {
        Legs_Score += index;
    }
    public static void upButtocksScore(int index)
    {
        Buttocks_Score += index;
    }
    public static void upThighsScore(int index)
    {
        Thighs_Score += index;
    }
    public static void upCalfScore(int index)
    {
        Calf_Score += index;
    }
    //-------------------------------------------------------------------
    private void Update()
    {
        int legsscore = (getButtocksScore() + getCalfScore() + getThighsScore()) / 3;
        if (legsscore >= Treshhold)
            Character_Stats.setLegs(1);
        else Character_Stats.setLegs(0);
        setLegsScore(legsscore);

        int handsscore = (getBicepsScore() + getForearmsScore() + getTricepsScore() + getShoulderScore()) / 4;
        if (handsscore >= Treshhold)
            Character_Stats.setHands(1);
        else Character_Stats.setHands(0);
        setHandsScore(handsscore);

        int bodyscore = (getChestScore() + getAbsScore() + getBackScore()) / 3;
        if (bodyscore >= Treshhold)
            Character_Stats.setBody(1);
        else Character_Stats.setBody(0);
        setBodyScore(bodyscore);

        int overall = (legsscore + handsscore + bodyscore) / 3;

        setOverall(overall);
    }
}

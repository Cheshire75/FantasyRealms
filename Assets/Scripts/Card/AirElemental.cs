using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirElemental : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += (eachAttrib(hand, "Weather") - 1) * 15;
            return bonus + power;
        }
        return 0;
    }
}

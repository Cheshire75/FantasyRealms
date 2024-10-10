using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainstorm : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += eachAttrib(hand, "Water") * 10;
            if (isPenalty)
            {
                unavailableAttrib(hand, "Fire");
                availableName(hand, "Lightning");
            }
            return bonus + power;
        }
        return 0;
    }
}

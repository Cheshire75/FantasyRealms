using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereName(hand, "Smoke") && isThereName(hand, "Wildfire"))
            {
                bonus = 50;
            }
            deletePenalty(hand, "Water");
            return bonus + power;
        }
        return 0;
    }
}

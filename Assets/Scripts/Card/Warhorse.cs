using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warhorse : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereAttrib(hand, "Leader") || isThereAttrib(hand, "Wizard"))
            {
                bonus = 14;
            }
            return power + bonus;
        }
        return 0;
    }
}

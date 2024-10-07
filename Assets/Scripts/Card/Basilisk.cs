using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basilisk : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        if (isAvailable)
        {
            if (isPenalty)
            {
                unavailableAttrib(hand, "Army");
                unavailableAttrib(hand, "Leader");
                unavailableAttrib(hand, "Beast");
                availableName(hand, "Basilisk");
            }
            return power;
        }
        else
        {
            return 0;
        }
    }
}

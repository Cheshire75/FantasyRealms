using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatFlood : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            unavailableAttrib(hand, "Army");
            unavailableAttrib(hand, "Earth");
            availableName(hand, "Mountain");
            unavailableAttrib(hand, "Fire");
            availableName(hand, "Lightning");
            return power;
        }
        return 0;
    }
}

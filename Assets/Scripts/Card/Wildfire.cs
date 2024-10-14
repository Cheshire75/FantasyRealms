using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wildfire : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        if (isAvailable)
        {
            unavailableAttrib(hand, "Army");
            unavailableAttrib(hand, "Earth");
            unavailableAttrib(hand, "Water");
            unavailableAttrib(hand, "Unknown");
            unavailableAttrib(hand, "Beast");
            unavailableAttrib(hand, "Leader");
            availableName(hand, "Mountain");
            availableName(hand, "GreatFlood");
            availableName(hand, "Island");
            availableName(hand, "Dragon");
            availableName(hand, "Unicorn");
            return power;
        }
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldOfKeth : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereAttrib(hand, "Leader"))
            {
                bonus = 15;
            }
            if (isThereAttrib(hand, "Leader") && isThereName(hand, "SwordOfKeth"))
            {
                bonus = 40;
            }
            return bonus + power;
        }
        return 0;
    }
}

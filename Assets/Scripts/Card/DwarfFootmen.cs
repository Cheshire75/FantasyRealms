using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfFootmen : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isPenalty)
            {
                bonus -= (eachAttrib(hand, "Army") - 1) * -2;
            }
            return bonus + power;
        }
        return 0;
    }
}

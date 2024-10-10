using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicWand : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereAttrib(hand, "Wizard"))
            {
                bonus = 25;
            }
            return bonus + power;
        }
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isPenalty)
            {
                if (!isThereAttrib(hand, "Wizard"))
                {
                    bonus = -40;
                }
            }
            return bonus + power;
        }
        return 0;
    }
}

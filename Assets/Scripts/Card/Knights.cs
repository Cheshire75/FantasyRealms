using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knights : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isPenalty)
            {
                if (!isThereAttrib(hand, "Leader"))
                {
                    bonus = -8;
                }
            }
            return bonus + power;
        }
        return 0;
    }
}

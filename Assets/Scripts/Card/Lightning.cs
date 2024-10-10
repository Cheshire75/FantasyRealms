using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereName(hand, "Rainstorm"))
            {
                bonus = 30;
            }
            return bonus + power;
        }
        return 0;
    }
}

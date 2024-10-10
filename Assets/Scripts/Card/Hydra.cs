using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydra : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereName(hand, "Swamp"))
            {
                bonus = 28;
            }
            return power + bonus;
        }
        return 0;
    }
}

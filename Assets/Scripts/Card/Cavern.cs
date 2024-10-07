using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cavern : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereName(hand, "DwarfFootmen") || isThereName(hand, "Dragon"))
            {
                bonus = 25;
            }
            deletePenalty(hand, "Weather");
            return bonus + power;
        }
        return 0;
    }
}

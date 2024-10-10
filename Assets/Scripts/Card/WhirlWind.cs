using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whirlwind : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereName(hand, "Rainstorm"))
            {
                if (isThereName(hand, "Blizzard") || isThereName(hand, "GreatFlood"))
                {
                    bonus = 40;
                }
            }
            return bonus + power;
        }
        return 0;
    }
}

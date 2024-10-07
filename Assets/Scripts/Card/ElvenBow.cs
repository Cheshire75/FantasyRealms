using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElvenBow : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereName(hand, "ElfArcher") || isThereName(hand, "Warlord") || isThereName(hand, "BeastTamer"))
            {
                bonus = 30;
            }
            return bonus + power;
        }
        return 0;
    }
}

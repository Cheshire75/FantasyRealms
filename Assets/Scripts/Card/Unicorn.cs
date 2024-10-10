using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicorn : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereName(hand, "Empress") || isThereName(hand, "Queen") || isThereName(hand, "Enchantress"))
            {
                bonus = 15;
            }
            if (isThereName(hand, "Princess"))
            {
                bonus = 30;
            }
            return power + bonus;
        }
        return 0;
    }
}

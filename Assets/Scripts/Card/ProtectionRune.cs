using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectionRune : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            foreach (var i in hand.container)
            {
                i.isPenalty = false;
            }
            return power + bonus;
        }
        return 0;
    }
}

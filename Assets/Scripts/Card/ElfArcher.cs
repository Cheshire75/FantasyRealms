using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfArcher : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (!isThereAttrib(hand, "Weather"))
            {
                bonus = 5;
            }
            return bonus + power;
        }
        return 0;
    }
}

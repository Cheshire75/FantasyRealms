using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastTamer : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += eachAttrib(hand, "Beast") * 9;
            deletePenalty(hand, "Beast");
            return power + bonus;
        }
        else
        {
            return 0;
        }
    }
}

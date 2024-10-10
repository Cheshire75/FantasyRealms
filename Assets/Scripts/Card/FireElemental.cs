using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireElemental : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += (eachAttrib(hand, "Fire") - 1) * 15;
            return power + bonus;
        }
        return 0;
    }
}

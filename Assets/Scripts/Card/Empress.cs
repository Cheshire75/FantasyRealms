using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empress : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += eachAttrib(hand, "Army") * 10;
            if (isPenalty)
            {
                bonus -= (eachAttrib(hand, "Leader") - 1) * 5;
            }
            return bonus + power;
        }
        return 0;
    }
}

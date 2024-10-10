using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rangers : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += eachAttrib(hand, "Earth");
            exclude(hand, "Army");
            return bonus + power;
        }
        return 0;
    }
}

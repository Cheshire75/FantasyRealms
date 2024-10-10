using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarDirigible : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isPenalty)
        {
            if (!isThereAttrib(hand, "Army") || isThereAttrib(hand, "Weather"))
            {
                isAvailable = false;
                foreach (var i in hand.container)
                {
                    if (i.cardName == "WarDirigible")
                    {
                        i.isAvailable = false;
                    }
                }
            }
        }
        if (isAvailable)
        {
            return bonus + power;
        }
        return 0;
    }
}

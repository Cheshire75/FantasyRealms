using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isPenalty)
            {
                if (isThereAttrib(hand, "Fire"))
                {
                    foreach (var i in hand.container)
                    {
                        if (i.cardName == "Smoke")
                        {
                            i.isAvailable = false;
                        }
                        return 0;
                    }
                }
            }
            return bonus + power;
        }
        return 0;
    }
}

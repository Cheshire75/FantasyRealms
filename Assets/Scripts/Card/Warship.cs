using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warship : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isPenalty)
        {
            if (!isThereAttrib(hand, "Water"))
            {
                isAvailable = false;
                foreach (var i in hand.container)
                {
                    if (i.cardName == "Warship")
                    {
                        i.isAvailable = false;
                    }
                }
            }
        }
        if (isAvailable)
        {
        }
        return 0;
    }
}

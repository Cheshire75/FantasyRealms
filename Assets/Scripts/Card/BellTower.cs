using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellTower : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereAttrib(hand, "Wizard"))
            {
                bonus = 15;
            }
            return bonus + power;
        }
        else
        {
            return 0;
        }
    }
}

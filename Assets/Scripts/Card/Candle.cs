using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereName(hand, "BookOfChange") && isThereName(hand, "BellTower") && isThereAttrib(hand, "Wizard"))
            {
                bonus = 100;
            }
            return bonus + power;
        }
        return 0;
    }
}

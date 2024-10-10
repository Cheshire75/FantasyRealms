using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordOfKeth : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isThereAttrib(hand, "Leader"))
            {
                bonus = 10;
                if (isThereName(hand, "ShieldOfKeth"))
                {
                    bonus = 40;
                }
            }
        }
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcmage : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        if (isAvailable)
        {
            int bonus = 0;
            if (isPenalty)
            {
                bonus -= eachAttrib(hand, "Leader") * -10;
                bonus -= (eachAttrib(hand, "Wizard") - 1) * -10;
            }
            return bonus + power;
        }
        else
        {
            return 0;
        }
    }
}

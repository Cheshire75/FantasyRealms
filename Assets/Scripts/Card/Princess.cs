using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Princess : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += eachAttrib(hand, "Army") * 8;
            bonus += eachAttrib(hand, "Wizard") * 8;
            bonus += (eachAttrib(hand, "Leader") - 1) * 8;
            return bonus + power;
        }
        return 0;
    }
}

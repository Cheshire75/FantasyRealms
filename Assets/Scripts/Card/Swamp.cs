using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swamp : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            if (isPenalty)
            {
                bonus -= eachAttrib(hand, "Army") * 3;
                bonus -= eachAttrib(hand, "Fire") * 3;
            }
        }
        return 0;
    }
}

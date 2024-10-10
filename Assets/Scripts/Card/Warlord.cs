using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warlord : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            foreach (var i in hand.container)
            {
                if (i.isAvailable && i.attrib == "Army")
                {
                    bonus += i.power;
                }
            }
            return power + bonus;
        }
        return 0;
    }
}

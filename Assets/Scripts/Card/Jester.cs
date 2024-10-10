using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jester : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        int cnt = 0;
        if (isAvailable)
        {
            foreach (var i in hand.container)
            {
                if (i.power % 2 == 1 && i.isAvailable)
                {
                    cnt++;
                }
            }
            bonus = cnt * 3;
            if (cnt == hand.container.Count)
            {
                bonus = 50;
            }
            return bonus + power;
        }
        return 0;
    }
}

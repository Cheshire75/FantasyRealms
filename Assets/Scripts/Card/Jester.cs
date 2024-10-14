using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jester : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        int cnt = 0;
        if (card.isAvailable)
        {
            foreach (var i in card.hand.container)
            {
                if (i.power % 2 == 1 && i.isAvailable)
                {
                    cnt++;
                }
            }
            bonus = cnt * 3;
            if (cnt == card.hand.container.Count)
            {
                bonus = 50;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

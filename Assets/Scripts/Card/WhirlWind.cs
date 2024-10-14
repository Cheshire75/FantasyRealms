using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whirlwind : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereName(card.hand, "Rainstorm"))
            {
                if (isThereName(card.hand, "Blizzard") || isThereName(card.hand, "GreatFlood"))
                {
                    bonus = 40;
                }
            }
            return bonus + card.power;
        }
        return 0;
    }
}

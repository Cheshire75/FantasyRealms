using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cavern : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereName(card.hand, "DwarfFootmen") || isThereName(card.hand, "Dragon"))
            {
                bonus = 25;
            }
            deletePenalty(card.hand, "Weather");
            return bonus + card.power;
        }
        return 0;
    }
}

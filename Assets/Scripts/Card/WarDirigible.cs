using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarDirigible : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isPenalty)
        {
            if (!isThereAttrib(card.hand, "Army") || isThereAttrib(card.hand, "Weather"))
            {
                card.isAvailable = false;
            }
        }
        if (card.isAvailable)
        {
            return bonus + card.power;
        }
        return 0;
    }
}

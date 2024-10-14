using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereName(card.hand, "Smoke") && isThereName(card.hand, "Wildfire"))
            {
                bonus = 50;
            }
            deletePenalty(card.hand, "Water");
            return bonus + card.power;
        }
        return 0;
    }
}

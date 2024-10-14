using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydra : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereName(card.hand, "Swamp"))
            {
                bonus = 28;
            }
            return card.power + bonus;
        }
        return 0;
    }
}

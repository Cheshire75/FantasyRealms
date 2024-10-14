using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElvenBow : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereName(card.hand, "ElfArcher") || isThereName(card.hand, "Warlord") || isThereName(card.hand, "BeastTamer"))
            {
                bonus = 30;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

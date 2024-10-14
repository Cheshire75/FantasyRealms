using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicorn : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereName(card.hand, "Empress") || isThereName(card.hand, "Queen") || isThereName(card.hand, "Enchantress"))
            {
                bonus = 15;
            }
            if (isThereName(card.hand, "Princess"))
            {
                bonus = 30;
            }
            return card.power + bonus;
        }
        return 0;
    }
}

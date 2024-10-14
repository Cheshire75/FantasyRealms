using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectionRune : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            foreach (var i in card.hand.container)
            {
                i.isPenalty = false;
            }
            return card.power + bonus;
        }
        return 0;
    }
}

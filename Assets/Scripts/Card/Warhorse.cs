using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warhorse : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereAttrib(card.hand, "Leader") || isThereAttrib(card.hand, "Wizard"))
            {
                bonus = 14;
            }
            return card.power + bonus;
        }
        return 0;
    }
}

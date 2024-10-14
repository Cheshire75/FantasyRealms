using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellTower : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereAttrib(card.hand, "Wizard"))
            {
                bonus = 15;
            }
            return bonus + card.power;
        }
        else
        {
            return 0;
        }
    }
}

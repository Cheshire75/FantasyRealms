using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicWand : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereAttrib(card.hand, "Wizard"))
            {
                bonus = 25;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

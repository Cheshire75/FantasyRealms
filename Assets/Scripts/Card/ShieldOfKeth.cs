using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldOfKeth : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereAttrib(card.hand, "Leader"))
            {
                bonus = 15;
            }
            if (isThereAttrib(card.hand, "Leader") && isThereName(card.hand, "SwordOfKeth"))
            {
                bonus = 40;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

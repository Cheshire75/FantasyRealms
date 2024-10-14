using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordOfKeth : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereAttrib(card.hand, "Leader"))
            {
                bonus = 10;
                if (isThereName(card.hand, "ShieldOfKeth"))
                {
                    bonus = 40;
                }
            }
            return bonus + card.power;
        }
        return 0;
    }
}

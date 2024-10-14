using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knights : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (card.isPenalty)
            {
                if (!isThereAttrib(card.hand, "Leader"))
                {
                    bonus = -8;
                }
            }
            return bonus + card.power;
        }
        return 0;
    }
}

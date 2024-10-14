using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCavalry : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (card.isPenalty)
            {
                bonus -= eachAttrib(card.hand, "Earth") * 2;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

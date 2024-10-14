using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastTamer : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            bonus += eachAttrib(card.hand, "Beast") * 9;
            deletePenalty(card.hand, "Beast");
            return card.power + bonus;
        }
        else
        {
            return 0;
        }
    }
}

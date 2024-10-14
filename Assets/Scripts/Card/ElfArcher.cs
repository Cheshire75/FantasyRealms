using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfArcher : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (!isThereAttrib(card.hand, "Weather"))
            {
                bonus = 5;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

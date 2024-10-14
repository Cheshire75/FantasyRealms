using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereName(card.hand, "Rainstorm"))
            {
                bonus = 30;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

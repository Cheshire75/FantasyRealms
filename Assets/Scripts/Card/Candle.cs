using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (isThereName(card.hand, "BookOfChange") && isThereName(card.hand, "BellTower") && isThereAttrib(card.hand, "Wizard"))
            {
                bonus = 100;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

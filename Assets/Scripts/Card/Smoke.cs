using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (card.isPenalty)
            {
                if (isThereAttrib(card.hand, "Fire"))
                {
                    foreach (var i in card.hand.container)
                    {
                        if (i.cardName == "Smoke")
                        {
                            i.isAvailable = false;
                        }
                        return 0;
                    }
                }
            }
            return bonus + card.power;
        }
        return 0;
    }
}

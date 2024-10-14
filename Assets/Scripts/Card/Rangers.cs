using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rangers : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            bonus += eachAttrib(card.hand, "Earth");
            exclude(card.hand, "Army");
            return bonus + card.power;
        }
        return 0;
    }
}

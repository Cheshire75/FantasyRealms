using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blizzard : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            bonus += eachAttrib(card.hand, "Water") * 10;
            if (card.isPenalty)
            {
                unavailableAttrib(card.hand, "Fire");
                availableName(card.hand, "Lightning");
            }
            return bonus + card.power;
        }
        return 0;
    }
}

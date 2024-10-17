using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterElemental : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            int cnt = eachAttrib(card.hand, "Water");
            if (card.attrib == "Water") cnt--;
            bonus = cnt * 15;
            return bonus + card.power;
        }
        return 0;
    }
}

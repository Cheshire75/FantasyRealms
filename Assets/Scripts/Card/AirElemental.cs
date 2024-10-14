using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirElemental : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            int cnt = eachAttrib(card.hand, "Weather");
            if (card.attrib == "Weather") cnt--;
            bonus += cnt * 15;
            return bonus + card.power;
        }
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthElemental : Effect
{

    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            int cnt = eachAttrib(card.hand, "Earth");
            if (card.attrib == "Earth") cnt--;
            bonus += cnt * 15;
            return bonus + card.power;
        }
        return 0;
    }
}

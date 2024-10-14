using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireElemental : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            int cnt = eachAttrib(card.hand, "Fire");
            if (card.attrib == "Fire") cnt--;
            bonus += cnt * 15;
            return card.power + bonus;
        }
        return 0;
    }
}

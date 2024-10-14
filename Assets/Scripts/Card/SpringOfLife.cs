using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringOfLife : Effect
{
    private bool isThere(Card card)
    {
        if (card.attrib == "Weapon") return true;
        if (card.attrib == "Water") return true;
        if (card.attrib == "Fire") return true;
        if (card.attrib == "Earth") return true;
        if (card.attrib == "Weather") return true;
        return false;
    }
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            int max = 0;
            foreach (var i in card.hand.container)
            {
                if (isThere(i))
                {
                    max = max < i.power ? i.power : max;
                }
            }
            bonus = max;
            return bonus + card.power;
        }
        return 0;
    }
}

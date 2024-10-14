using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warlord : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            foreach (var i in card.hand.container)
            {
                if (i.isAvailable && i.attrib == "Army")
                {
                    bonus += i.power;
                }
            }
            return card.power + bonus;
        }
        return 0;
    }
}

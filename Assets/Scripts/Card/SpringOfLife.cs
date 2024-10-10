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
    }
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            int max = 0;
            foreach (var i in hand.container)
            {
                if (isThere(i))
                {
                    max = max < i.power ? i.power : max;
                }
            }
            bonus = max;
            return bonus + power;
        }
        return 0;
    }
}

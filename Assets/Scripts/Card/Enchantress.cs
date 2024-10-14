using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enchantress : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            bonus += eachAttrib(card.hand, "Earth") * 5;
            bonus += eachAttrib(card.hand, "Weather") * 5;
            bonus += eachAttrib(card.hand, "Water") * 5;
            bonus += eachAttrib(card.hand, "Fire") * 5;
            return bonus + card.power;
        }
        return 0;
    }
}

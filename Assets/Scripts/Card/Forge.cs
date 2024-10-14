using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forge : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            bonus += eachAttrib(card.hand, "Weapon") * 9;
            bonus += eachAttrib(card.hand, "Artifact") * 9;
            return bonus + card.power;
        }
        return 0;
    }
}

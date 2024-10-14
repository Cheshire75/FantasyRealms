using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empress : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            bonus += eachAttrib(card.hand, "Army") * 10;
            if (card.isPenalty)
            {
                int cnt = eachAttrib(card.hand, "Leader");
                if (card.attrib == "Leader") cnt--;
                bonus += cnt * -5;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

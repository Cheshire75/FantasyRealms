using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Princess : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            int cnt = eachAttrib(card.hand, "Army") + eachAttrib(card.hand, "Wizard") + eachAttrib(card.hand, "Leader");
            if (card.attrib == "Leader") cnt--;
            bonus = cnt * 8;
            return bonus + card.power;
        }
        return 0;
    }
}

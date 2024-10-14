using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcmage : Effect
{
    public int score(Card card)
    {
        if (card.isAvailable)
        {
            int bonus = 0;
            if (card.isPenalty)
            {
                int cnt = eachAttrib(card.hand, "Leader") + eachAttrib(card.hand, "Wizard");
                if (card.attrib == "Leader" || card.attrib == "Wizard") cnt--;

                bonus -= cnt * 10;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

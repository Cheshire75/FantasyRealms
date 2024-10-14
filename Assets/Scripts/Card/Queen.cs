using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            int cnt = eachAttrib(card.hand, "Army");
            if (isThereName(card.hand, "King"))
            {
                bonus = cnt * 20;
            }
            else
            {
                bonus = cnt * 5;
            }
            return card.power + bonus;
        }
        return 0;
    }
}

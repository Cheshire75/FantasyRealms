using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : Effect
{
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            bonus += eachAttrib(card.hand, "Beast") * 12;
            if (isThereName(card.hand, "ElfArcher"))
            {
                bonus += 12;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

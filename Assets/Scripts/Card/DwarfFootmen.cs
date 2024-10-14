using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DwarfFootmen : Effect
{
    void Start()
    {
        penaltyAttrib.Add("Army");
    }
    public int score(Card card)
    {
        int bonus = 0;
        if (card.isAvailable)
        {
            if (card.isPenalty)
            {
                int cnt = eachAttrib(card.hand, penaltyAttrib[0]);
                if (card.attrib == "Army") cnt--;
                bonus += cnt * -2;
            }
            return bonus + card.power;
        }
        return 0;
    }
}

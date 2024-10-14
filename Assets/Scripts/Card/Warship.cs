using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warship : Effect
{
    public int score(Card card)
    {
        if (card.isPenalty)
        {
            if (!isThereAttrib(card.hand, "Water"))
            {
                card.isAvailable = false;
            }
        }
        if (card.isAvailable)
        {
            foreach (var i in card.hand.container)
            {
                if (i.attrib == "Water")
                {
                    GameObject.Find(i.cardName).GetComponent<Effect>().penaltyAttrib.Remove("Army");
                }
            }
            return card.power;
        }
        return 0;
    }
}

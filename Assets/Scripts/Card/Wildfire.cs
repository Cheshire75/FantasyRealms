using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wildfire : Effect
{
    void Start()
    {
        penaltyAttrib.Add("Army");
        penaltyAttrib.Add("Earth");
        penaltyAttrib.Add("Water");
        penaltyAttrib.Add("Unknown");
        penaltyAttrib.Add("Beast");
        penaltyAttrib.Add("Leader");
    }
    public int score(Card card)
    {
        if (card.isAvailable)
        {
            foreach (var i in penaltyAttrib)
            {
                unavailableAttrib(card.hand, i);
            }
            availableName(card.hand, "Mountain");
            availableName(card.hand, "GreatFlood");
            availableName(card.hand, "Island");
            availableName(card.hand, "Dragon");
            availableName(card.hand, "Unicorn");
            return card.power;
        }
        return 0;
    }
}

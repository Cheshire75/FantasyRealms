using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatFlood : Effect
{
    [SerializeField]
    public List<string> penaltyAttrib = new List<string>();
    void Start()
    {
        penaltyAttrib.Add("Army");
        penaltyAttrib.Add("Earth");
        penaltyAttrib.Add("Fire");
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
            availableName(card.hand, "Lightning");
            return card.power;
        }
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basilisk : Effect
{
    public List<string> penaltyAttrib = new List<string>();
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        penaltyAttrib.Add("Army");
        penaltyAttrib.Add("Leader");
        penaltyAttrib.Add("Beast");
    }
    public int score(Card card)
    {
        if (card.isAvailable)
        {
            if (card.isPenalty)
            {
                foreach (var i in penaltyAttrib)
                {
                    unavailableAttrib(card.hand, i);
                }
                availableName(card.hand, "Basilisk");
            }
            return card.power;
        }
        else
        {
            return 0;
        }
    }
}

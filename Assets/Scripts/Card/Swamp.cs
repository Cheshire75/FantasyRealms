using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swamp : Effect
{
    [SerializeField]
    public List<string> penaltyAttrib = new List<string>();
    void Start()
    {
        penaltyAttrib.Add("Army");
        penaltyAttrib.Add("Fire");
    }
    public int score(Card card)
    {

        int bonus = 0;
        if (card.isAvailable)
        {
            if (card.isPenalty)
            {
                foreach (var i in penaltyAttrib)
                {
                    bonus -= eachAttrib(card.hand, i) * 3;
                }
            }
            return card.power + bonus;
        }
        return 0;
    }
}

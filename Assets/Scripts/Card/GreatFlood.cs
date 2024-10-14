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
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        if (isAvailable)
        {
            foreach (var i in penaltyAttrib)
            {
                unavailableAttrib(hand, i);
            }

            availableName(hand, "Mountain");
            availableName(hand, "Lightning");
            return power;
        }
        return 0;
    }
}

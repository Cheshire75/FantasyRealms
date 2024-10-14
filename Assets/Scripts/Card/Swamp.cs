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
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {

        int bonus = 0;
        if (isAvailable)
        {
            if (isPenalty)
            {
                foreach (var i in penaltyAttrib)
                {
                    bonus -= eachAttrib(hand, i) * 3;
                }
            }
            return power + bonus;
        }
        return 0;
    }
}

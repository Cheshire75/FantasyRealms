using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necromancer : Effect
{
    public void necromancer(Hand hand, Card card)
    {
        hand.container.Add(card);
    }
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            return power;
        }
        return 0;
    }
}

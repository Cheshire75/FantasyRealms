using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            int cnt = eachAttrib(hand, "Army");
            if (isThereName(hand, "Queen"))
            {
                bonus = cnt * 20;
            }
            else
            {
                bonus = cnt * 5;
            }
            return power + bonus;
        }
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forge : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += eachAttrib(hand, "Weapon") * 9;
            bonus += eachAttrib(hand, "Artifact") * 9;
            return bonus + power;
        }
        return 0;
    }
}

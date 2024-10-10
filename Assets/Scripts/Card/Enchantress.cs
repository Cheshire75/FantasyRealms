using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enchantress : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += eachAttrib(hand, "Earth") * 5;
            bonus += eachAttrib(hand, "Weather") * 5;
            bonus += eachAttrib(hand, "Water") * 5;
            bonus += eachAttrib(hand, "Fire") * 5;
            return bonus + power;
        }
        return 0;
    }
}

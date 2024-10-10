using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            bonus += eachAttrib(hand, "Beast") * 12;
            if (isThereName(hand, "ElfArcher"))
            {
                bonus += 12;
            }
            return bonus + power;
        }
        return 0;
    }
}

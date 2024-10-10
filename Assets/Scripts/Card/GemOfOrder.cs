using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemOfOrder : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        int bonus = 0;
        if (isAvailable)
        {
            int cnt = 0;
            List<int> powersOfHand = new List<int>[hand.container.Count];
            foreach (var i in hand.container)
            {
                if (i.isAvailable)
                {
                    powersOfHand.Add(i.power);
                }
            }
            powersOfHand.Sort();
            for (int i = 0; i < powersOfHand.Count; i++)
            {
                int set = powersOfHand[i];
                while (powersOfHand.Find(set + 1) != null)
                {
                    cnt++;
                    set++;
                }

            }
        }
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Collector : Effect
{
    public int score(Hand hand, int power, bool isAvailable, bool isPenalty)
    {
        if (isAvailable)
        {
            List<int> numOfAttrib = new List<int>();
            numOfAttrib.Add(eachAttrib(hand, "Army"));
            numOfAttrib.Add(eachAttrib(hand, "Weather"));
            numOfAttrib.Add(eachAttrib(hand, "Earth"));
            numOfAttrib.Add(eachAttrib(hand, "Wizard"));
            numOfAttrib.Add(eachAttrib(hand, "Weapon"));
            numOfAttrib.Add(eachAttrib(hand, "Water"));
            numOfAttrib.Add(eachAttrib(hand, "Fire"));
            numOfAttrib.Add(eachAttrib(hand, "Beast"));
            numOfAttrib.Add(eachAttrib(hand, "Artifact"));
            numOfAttrib.Add(eachAttrib(hand, "Leader"));
            int maxNumOfAttrib = numOfAttrib.Max();

            int bonus = 0;
            if (maxNumOfAttrib >= 3)
            {
                switch (maxNumOfAttrib)
                {
                    case 3:
                        bonus = 10;
                        break;
                    case 4:
                        bonus = 40;
                        break;
                    case 5:
                        bonus = 100;
                        break;
                }
            }
            return bonus + power;
        }
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Collector : Effect
{
    public int score(Card card)
    {
        if (card.isAvailable)
        {
            List<int> numOfAttrib = new List<int>();
            numOfAttrib.Add(eachAttrib(card.hand, "Army"));
            numOfAttrib.Add(eachAttrib(card.hand, "Weather"));
            numOfAttrib.Add(eachAttrib(card.hand, "Earth"));
            numOfAttrib.Add(eachAttrib(card.hand, "Wizard"));
            numOfAttrib.Add(eachAttrib(card.hand, "Weapon"));
            numOfAttrib.Add(eachAttrib(card.hand, "Water"));
            numOfAttrib.Add(eachAttrib(card.hand, "Fire"));
            numOfAttrib.Add(eachAttrib(card.hand, "Beast"));
            numOfAttrib.Add(eachAttrib(card.hand, "Artifact"));
            numOfAttrib.Add(eachAttrib(card.hand, "Leader"));
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
            return bonus + card.power;
        }
        return 0;
    }
}

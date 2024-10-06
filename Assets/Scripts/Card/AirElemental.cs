using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirElemental : Card
{
    public AirElemental()
    {
        cardName = "AirElemental";
        attrib = "Weather";
        power = 4;
        order = 10;
        isAvailable = true;
        isPenalty = false;
    }
    public override int scroing()
    {
        power -= (eachAttrib("Weather") - 1) * 15;
        return power;
    }
}

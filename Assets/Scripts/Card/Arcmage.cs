using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcmage : Card
{
    public Arcmage()
    {
        cardName = "Arcmage";
        attrib = "Wizard";
        power = 25;
        order = 10;
        isAvailable = true;
        isPenalty = true;
    }
    public override int scroing()
    {
        power -= (eachAttrib("Leader")) * -10;
        power -= (eachAttrib("Wizard") - 1) * -10;
        return power;
    }
}

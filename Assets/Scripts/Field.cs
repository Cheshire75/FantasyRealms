using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : Container
{
    public Field()
    {
        container = new List<Card>();
    }

    public bool isFull()
    {
        if (container.Count >= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void showUp()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : Container
{
    [SerializeField]
    public CardSO cardSO;
    public Deck()
    {
        container = new List<GameObject>();
    }
    public void setup()
    {
        clear();
        foreach (var i in cardSO.AllCards)
        {
            container.Add(i);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : Container
{
    [SerializeField]
    public Deck deck;
    public int score;
    public int playerNumber;
    public Hand()
    {
        container = new List<GameObject>();
    }
    public void draw()
    {
        if (container.Count < 7)
        {

        }
    }
}

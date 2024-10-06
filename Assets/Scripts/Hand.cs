using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hand : Container
{
    [SerializeField]
    public Deck deck;
    public int score;
    public int playerNumber;
    public Field field;

    public Hand()
    {
        container = new List<Card>();
    }

    public void setup()
    {
        Debug.Log("Deck Count:" + deck.container.Count + "\nHand Count:" + container.Count + "\n");
        for (int i = container.Count; i < 7; i++)
        {
            receive(deck.send(Random.Range(0, deck.container.Count - 1)));
        }
    }

    public void draw()
    {
        receive(deck.send(Random.Range(0, deck.container.Count - 1)));
    }

    public void discard(int num)
    {
        field.receive(send(num));
    }

    public void calScore()
    {

    }

    void Start()
    {
        setup();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clear();
            setup();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            discard(0);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            draw();
        }
    }
}

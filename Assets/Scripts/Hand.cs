using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

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
            draw();
        }
    }

    public void draw()
    {
        Card tmp = deck.send(Random.Range(0, deck.container.Count - 1));
        tmp.hand = this;
        receive(tmp);
        GameObject DrawingCard = Instantiate(tmp.prefab, deck.GetComponent<Transform>().position, Quaternion.identity);
        DrawingCard.transform.DOMove(new Vector3((float)(-7 + 2 * (container.Count - 1)), -3, 0), (float)0.5);

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

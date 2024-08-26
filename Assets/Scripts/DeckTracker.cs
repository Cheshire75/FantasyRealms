using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckTracker : MonoBehaviour
{
    public static DeckTracker Inst { get; private set; }
    void Awake() => Inst = this;

    [SerializeField] CardSO cardSO;
    List<Card> deck;


    // Start is called before the first frame update
    void Start()
    {
        deck = new List<Card>();
        for (int i = 0; i < 54; i++)
        {
            deck.Add(cardSO.cards[i]);
        }

        for (int i = 0; i < 54; i++)
        {
            int pick = Random.Range(i, 54);
            Card tmp = deck[pick];
            deck[pick] = deck[i];
            deck[i] = tmp;
        }
    }

    public Card drawCard()
    {
        if (deck.Count > 0)
        {
            Card tmp = deck[0];
            deck.RemoveAt(0);
            return tmp;
        }
        else
        {
            return null;
        }
    }
}

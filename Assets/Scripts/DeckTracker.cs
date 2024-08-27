using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeckTracker : MonoBehaviour
{
    public static DeckTracker Inst { get; private set; }
    void Awake() => Inst = this;

    [SerializeField] CardSO cardSO;
    List<Card> deck;
    [SerializeField] Hand hand;

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
        Card tmp = deck[0];
        deck.RemoveAt(0);
        return tmp;
    }

    public void setUp(Hand hand)
    {
        for (int i = 0; i < 7; i++)
        {
            hand.myCards[i] = drawCard();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            setUp(hand);
            for (int i = 0; i < 7; i++)
            {
                hand.spread.Add(Instantiate(hand.myCards[i].card_prefab));
                hand.spread[i].transform.SetParent(hand.transform);
                hand.spread[i].transform.position = new Vector2(-7 + 2 * i, -3.3f);
            }
        }
    }
}

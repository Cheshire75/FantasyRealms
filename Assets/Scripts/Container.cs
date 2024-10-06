using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public List<Card> container;
    public void receive(Card card)
    {
        container.Add(card);
    }
    public Card send(int num)
    {
        Card tmp = container[num];
        container.RemoveAt(num);
        return tmp;
    }
    public void clear()
    {
        container.Clear();
    }
}

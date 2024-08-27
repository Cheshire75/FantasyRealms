using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hand : MonoBehaviour
{
    // Start is called before the first frame update
    public Card[] myCards;
    public List<GameObject> spread;
    public Hand()
    {
        myCards = new Card[8];
    }
    void Start()
    {
    }
}

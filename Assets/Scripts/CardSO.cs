using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;




[System.Serializable]
public class Card
{
    public string cardName;
    public string attrib;
    public int power;
    public int order;
    public bool isAvailable;
    public bool isPenalty;
    public GameObject prefab;
    public Hand hand;
}

[CreateAssetMenu(fileName = "CardSO", menuName = "ScriptableObject/CardSO")]
public class CardSO : ScriptableObject
{
    public Card[] AllCards = new Card[55];
}
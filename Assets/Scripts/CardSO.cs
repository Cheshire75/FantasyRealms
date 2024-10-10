using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Effect : MonoBehaviour
{
    protected bool isThereAttrib(Hand hand, string _attrib)
    {
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib && i.isAvailable)
            {

                return true;
            }
        }
        return false;
    }

    protected bool isThereName(Hand hand, string _name)
    {
        foreach (var i in hand.container)
        {
            if (i.cardName == _name && i.isAvailable)
            {
                return true;
            }
        }
        return false;
    }

    protected int eachAttrib(Hand hand, string _attrib)
    {
        int cnt = 0;
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib && i.isAvailable)
            {
                cnt++;
            }
        }
        return cnt;
    }

    protected void exclude(Hand hand, string _attrib)
    {
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib)
            {
                i.attrib = "";
            }
        }
    }

    protected void include(Hand hand, string _attrib)
    {
        foreach (var i in hand.container)
        {
            if (i.attrib == "")
            {
                i.attrib = _attrib;
            }
        }
    }

    protected void unavailableAttrib(Hand hand, string _attrib)
    {
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib)
            {
                i.isAvailable = false;
            }
        }
    }

    protected void availableName(Hand hand, string _name)
    {
        foreach (var i in hand.container)
        {
            if (i.cardName == _name)
            {
                i.isAvailable = true;
            }
        }
    }

    protected void deletePenalty(Hand hand, string _attrib)
    {
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib)
            {
                i.isPenalty = false;
            }
        }
    }
}
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
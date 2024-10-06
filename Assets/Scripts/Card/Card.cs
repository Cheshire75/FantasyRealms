using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Card : MonoBehaviour
{
    public string cardName;
    public string attrib;
    public int power;
    public int order;
    public bool isAvailable;
    public bool isPenalty;
    public GameObject prefab;
    public Hand hand;
    abstract public int scroing();

    protected bool isThereAttrib(string _attrib)
    {
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib)
            {
                return true;
            }
        }
        return false;
    }

    protected bool isThereName(string _name)
    {
        foreach (var i in hand.container)
        {
            if (i.cardName == _name)
            {
                return true;
            }
        }
        return false;
    }

    protected int eachAttrib(string _attrib)
    {
        int cnt = 0;
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib)
            {
                cnt++;
            }
        }
        return cnt;
    }

    protected void exclude(string _attrib)
    {
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib)
            {
                i.attrib = "";
            }
        }
    }

    protected void unavailableAttrib(string _attrib)
    {
        foreach (var i in hand.container)
        {
            if (i.attrib == _attrib)
            {
                i.isAvailable = false;
            }
        }
    }

    protected void availableName(string _name)
    {
        foreach (var i in hand.container)
        {
            if (i.cardName == _name)
            {
                i.isAvailable = true;
            }
        }
    }

    protected void deletePenalty(string _attrib)
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

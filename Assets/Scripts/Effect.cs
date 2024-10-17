using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public List<string> penaltyAttrib = new List<string>();
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
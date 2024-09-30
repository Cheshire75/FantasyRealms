using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public List<GameObject> container;
    public void receive(GameObject card)
    {
        container.Add(card);
    }
    public GameObject send(int num)
    {
        GameObject tmp = container[num];
        container.RemoveAt(num);
        return tmp;
    }
    public void clear()
    {
        container.Clear();
    }
}

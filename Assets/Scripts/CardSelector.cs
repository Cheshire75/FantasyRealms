using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSelector : MonoBehaviour
{
    public static void spread(GameObject UI, List<Card> input)
    {
        Transform scrollView = UI.transform.GetChild(0);
        Transform viewPort = scrollView.GetChild(0);
        Transform content = viewPort.GetChild(0);
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }
        foreach (Card card in input)
        {
            GameObject item = Instantiate(card.prefab, content);
            item.AddComponent<LayoutElement>().preferredWidth = 2;

        }
        UI.SetActive(true);
    }
}

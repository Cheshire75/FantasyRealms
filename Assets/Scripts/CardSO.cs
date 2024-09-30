using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName = "ScriptableObject/CardSO")]
public class CardSO : ScriptableObject
{
    [SerializeField]
    public GameObject[] AllCards = new GameObject[55];
}
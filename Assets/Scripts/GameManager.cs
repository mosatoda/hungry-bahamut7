using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject cardPrefab;
    [SerializeField] Transform playerHand;
 
    void Start()
    {
        // 手札を1枚配る（自分）
        Instantiate(cardPrefab, playerHand);
    }
}

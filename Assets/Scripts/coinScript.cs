using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public static event Action OnCoinsCollected;

    void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            OnCoinsCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
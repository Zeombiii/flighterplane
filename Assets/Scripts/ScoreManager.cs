using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public int Coins { get; private set; }

    public UnityEvent<ScoreManager> OnCoinsCollected;

    public void CoinsCollected()
    {
        Coins++;
        OnCoinsCollected.Invoke(this);
    }
}

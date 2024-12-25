using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentCoin : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtCoinAmount;
    public static int currentCoin = 0;

    /*
    private void OnEnable()
    {
        DOVirtual.DelayedCall(0.05f, () => { GameManager.Instance.eventUpdateCoin += UpdateCoin;
        UpdateCoin();
        });
        
    }

    private void UpdateCoin()
    {
        if(currentCoin < 0) { currentCoin = 0; } else { currentCoin = GameManager.Instance.currentCoin; }

        txtCoinAmount.text = "$"+currentCoin.ToString();
    }
    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource CoinFx;

    public void OnTriggerEnter(Collider other)
    {
        ;
        CoinFx.Play();
        IncreaseScore.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}

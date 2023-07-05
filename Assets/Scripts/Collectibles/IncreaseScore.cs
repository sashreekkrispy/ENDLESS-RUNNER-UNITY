using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coinCount = 0;
    public GameObject coinCountDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;


    }
}

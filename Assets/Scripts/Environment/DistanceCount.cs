using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DistanceLevel : MonoBehaviour
{
    public GameObject distanceNumber;
    public int distance;
    public bool addingDis = false;
    public float disDelay = 0.25f;



    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(addingDistance());



        }

        IEnumerator addingDistance()
        {
            distance += 1;
            distanceNumber.GetComponent<TextMeshProUGUI>().text = "" + distance;
            yield return new WaitForSeconds(disDelay);
            addingDis = false;


        }

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasket : MonoBehaviour
{
    public GameObject zaun;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Egg 1" && other.name == "Egg 2" && other.name == "Egg 3")
        {
            zaun.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasket : MonoBehaviour
{
    public GameObject zaun;
    public int amountOfEggInBasket;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "ThrowEggs01")
        {
            Debug.Log("ThrowEggs01");
            amountOfEggInBasket++;
        }

        if (other.name == "ThrowEggs02")
        {
            Debug.Log("ThrowEggs02");
            amountOfEggInBasket++;
        }

        if (other.name == "ThrowEggs03")
        {
            Debug.Log("ThrowEggs03");
            amountOfEggInBasket++;
        }
    }

    public void Update()
    {
        if (amountOfEggInBasket == 3)
        {
            zaun.SetActive(false);
        }
    }
}

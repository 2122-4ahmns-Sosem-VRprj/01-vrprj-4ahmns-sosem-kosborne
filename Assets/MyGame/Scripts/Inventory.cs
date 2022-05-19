using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int eggAmount = 0;
    public Animator animator;
    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;


    public void CollectingEgg()
    {
        eggAmount++;
        animator.SetBool("PickUp", true);
    }

    public void Update()
    {
        if (eggAmount == 1)
        {
            Instantiate(egg1);
        }

        if (eggAmount == 2)
        {
            Instantiate(egg2);
        }

        if (eggAmount == 3)
        {
            Instantiate(egg3);
        }
    }

}

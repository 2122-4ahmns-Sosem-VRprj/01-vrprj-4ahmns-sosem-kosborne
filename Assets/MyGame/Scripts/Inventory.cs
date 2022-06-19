using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int eggAmount = 0;
    public Animator[] animator;

    public GameObject RandomParent;
    public GameObject finalEgg01 = null;

    public void CollectingEgg(int egg)
    {
        eggAmount++;
        Debug.Log(egg);
        animator[egg].SetBool("PickUp", true);
    }

    public void InstantiateEgg()
    {
        if (finalEgg01 == null && eggAmount == 1)
        {
            Debug.Log("Create final Egg!");
            finalEgg01.gameObject.transform.parent = RandomParent.transform;
        }
    }

}

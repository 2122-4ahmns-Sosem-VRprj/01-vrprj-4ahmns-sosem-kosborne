using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScriptAudio : MonoBehaviour
{
    public AudioSource au;

    public void Start()
    {
        GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            au.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

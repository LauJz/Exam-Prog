using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Light lightSource; 
    public bool isTriggered = false; 

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
            lightSource.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isTriggered = false;
            lightSource.enabled = false;
        }
    }
}

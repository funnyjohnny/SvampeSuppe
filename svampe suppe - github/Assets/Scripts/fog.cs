using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float fogDensity = 1f;

    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Player")
        {
        RenderSettings.fogDensity = fogDensity;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            RenderSettings.fogDensity = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

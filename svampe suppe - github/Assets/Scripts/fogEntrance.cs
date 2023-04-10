using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogEntrance : MonoBehaviour
{

    public float fogDensity = 0.1f;
    public Transform player;
    public Transform fogDistancePoint;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            RenderSettings.fogDensity = 0;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            RenderSettings.fogDensity = fogDensity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        fogDensity = (0.1f / (int)Vector3.Distance(player.position, fogDistancePoint.position));
    }
}

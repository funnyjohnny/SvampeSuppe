using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DREJ : MonoBehaviour
{
    public float z;

    void Start()
    {
        //velocity
    }

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, z)); //applying rotation
    }
}

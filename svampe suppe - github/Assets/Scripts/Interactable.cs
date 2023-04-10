using System.Collections;
using UnityEngine.AI;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public NavMeshAgent agent;

    public GameObject HIT;

    public float rayLength = 3;
    public Camera FpCamera;


    public GameObject DialogObject;


    private void Start()
    {
        FpCamera = Camera.main;
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = FpCamera.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit, rayLength))
            {
                HIT = hit.collider.gameObject;



                if (hit.transform.name == "NPC") { 
                    if (DialogObject.activeSelf == false)
                    {
                        Interact();
                    }
                    
                }

                //if (hit.transform.tag == "Item") { InteractItem();}


            }
        }
    }


    
    public virtual void Interact()
    {
        Debug.Log("Interacting with base class.");
    }

    public virtual void InteractItem()
    {
        Debug.Log("Interacting with base class.");
        
    }



    
}

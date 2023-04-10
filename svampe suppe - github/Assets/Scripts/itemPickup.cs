using UnityEngine;
using System;

public class itemPickup : Interactable
{



    public static event Action<Item> ItemGotPickedUp;
    public Item item;

    //public GameObject milkGoalObjectWithScript);

    
        private void Start()
    {
        //milkGoalObjectWithScript = GameObject.Find("MilkGoalReferenceObject");
        //milkGoalObjectWithScript.GetComponent<MilkGoal>();

    }

    // public int CurrentAmount { get; set; }

    public override void InteractItem()
    {
        base.InteractItem();


        //PickUp();

    }

    private void Update()
    {

        FpCamera = Camera.main;


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = FpCamera.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit, rayLength))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    if (hit.transform.tag == "Item") { PickUp();
                    }
                }

            }
        }
    }


    public void PickUp()
    {

        Debug.Log("Picking up " + item.name);
        
        bool wasPickedUp = Inventory.instance.Add(item);
        ItemGotPickedUp?.Invoke(item);

        //milkGoalObjectWithScript.MilkGoal.ItemWasPickedUpToInventory("SkovSvamp");

        #region CheckHvilketItem
        if (item.name == "SkovSvamp")
        {
            Debug.Log("Din Mor er en fkn luder");

            //CurrentAmount++;
            

        }


        #endregion
        if (wasPickedUp)
        Destroy(gameObject);



    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkGoal : Goal
{
    public string ItemName { get; set; }

    

    public MilkGoal(string itemName, string description, bool completed, int currentAmount, int requiredAmount)
    {
        this.ItemName = itemName;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;

    }

    public override void Init()
    {
        base.Init();
        //CombatEvents.OnEnemyDeath += EnemyDied;
        //itemPickup.PickUp += ItemWasPickedUpToInventory;
        itemPickup.ItemGotPickedUp += ItemWasPickedUpToInventory;
    }


    //SKLA BARE CALLES FRA PICKUP SCRIPTET, MEN KAN IKKE FINDE UD AF AT REFERENCE DET HER SCRIPT. 
    public void ItemWasPickedUpToInventory(Item item)
    {
        if(item.name == this.ItemName){
            Debug.Log("Fuck ja!");
            this.CurrentAmount++;
        }
    }


    //void EnemyDied(Ienemy enemy)
    //{
    //  if (enemyID == this.EnemyID)
    //  {
    //      this.CurrentAmount++;
    //      Evaluate();
    //  }
    //}


}

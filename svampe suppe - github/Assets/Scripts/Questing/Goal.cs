using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// HAR LIGE SAT MONOBEHAVIOUR IND, ER IKKE SIKKER P� OM DEN KAN V�RE DER.
public class Goal : MonoBehaviour
{

    public string Description { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }
    public int RequiredAmount { get; set; }


    public virtual void Init()
    {
        //default init stuff
    }


    public void Evaluate()
    {
        if (CurrentAmount >= RequiredAmount)
        {
            Complete();
        }
    }

    public void Complete()
    {
        Completed = true;
    }


}

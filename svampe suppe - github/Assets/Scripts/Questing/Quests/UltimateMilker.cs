using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateMilker : Quest
{

    private void Start()
    {
        QuestName = "Ultimate Milker";
        Description = "MILK MANY GOATS";


        Goals.Add(new MilkGoal("SkovSvamp", "Milk 13 Goats", false, 0, 1));
        //bare tilføj flere af dem over til flere goals


        Goals.ForEach(g => g.Init());


    }

}

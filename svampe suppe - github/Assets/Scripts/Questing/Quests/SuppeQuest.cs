using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuppeQuest : Quest
{
    private void Start()
    {
        QuestName = "Find ingredienser til svampesuppe";
        Description = "Find X Skovsampe, X Grottesvampe og X fløder og aflever dem til Suppe Sigurd";


        Goals.Add(new MilkGoal("SkovSvamp", "Find x Skovsampe", false, 0, 1));
        Goals.Add(new MilkGoal("GrotteSvamp", "Find X Grottesvampe", false, 0, 1));
        Goals.Add(new MilkGoal("GrotteSvamp", "Find X fløder", false, 0, 1));
        //bare tilføj flere af dem over til flere goals


        Goals.ForEach(g => g.Init());



    }
}

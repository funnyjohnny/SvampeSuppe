using System.Collections;
using UnityEngine;
using UnityEngine.AI;



public class QuestGiver : NPC
{

    public GameObject GoalsPane;
    

    public bool AssignedQuest { get; set; }
    public bool Helped { get; set; }

    [SerializeField]
    private GameObject quests;

    [SerializeField]
    private string questType;

    public Quest Quest { get; set; }

    public override void Interact()
    {
        base.Interact();
        if(!AssignedQuest && !Helped)
        {
            AssignQuest();
        }
        else if (AssignedQuest && !Helped)
        {
            checkQuest();
        }
        else
        {
            //her skal cutscenen måske være
        }
    }
    

    void AssignQuest()
    {
        AssignedQuest = true;

        Quest = (Quest)quests.AddComponent(System.Type.GetType(questType));


        GoalsPane.SetActive(!GoalsPane.activeSelf);

    }


    void checkQuest()
    {
        if (Quest.Completed)
        {
            //Quest.GiveReward(); i stedet skal der komme cutscenen slut
            Helped = true;
            AssignedQuest = false;
        }
        else
        {
            DialogueSystem.Instance.AddNewDialogue(new string[] { "Aww manner!", "Du mangler altså stadig nogle ting." }, name);
        }
    }
    

}

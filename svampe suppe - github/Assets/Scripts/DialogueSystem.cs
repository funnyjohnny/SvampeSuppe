using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{

    public static DialogueSystem Instance {get; set;}
    public GameObject DialoguePanel;
    public string npcName;
    public List<string> dialogueLines = new List<string>();


    Button continueButton;
    TMPro.TextMeshProUGUI dialogueText, nameText;
    int dialogueIndex;



    void Awake()
    {

        continueButton = DialoguePanel.transform.Find("Continue").GetComponent<Button>();
        dialogueText = DialoguePanel.transform.Find("Text").GetComponent<TMPro.TextMeshProUGUI>();
        nameText = DialoguePanel.transform.Find("NPCName").GetChild(0).GetComponent<TMPro.TextMeshProUGUI>();
        continueButton.onClick.AddListener(delegate { ContinueDialogue(); });
        DialoguePanel.SetActive(false);

        if (Instance != null && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }


    private void Update()
    {
        



        
    }

    public void AddNewDialogue(string[] lines, string npcName)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>(lines.Length);
        dialogueLines.AddRange(lines);

        Debug.Log(dialogueLines.Count);

        this.npcName = npcName;
        CreateDialogue();
    }


    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;
        DialoguePanel.SetActive(true);
    }



    public void ContinueDialogue()
    {
        if (dialogueIndex < dialogueLines.Count - 1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            DialoguePanel.SetActive(false);
        }



    }

}

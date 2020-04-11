using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [HideInInspector]
    public bool gameOverBool;
    private Queue<string> sentences;

    public Text NPCName;
    public Text NPCSentence;

    public Animator animator; //TextBubble Animator.

    public bool dialogueActive;
    public bool questGiver;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {

            dialogueActive = true;
            Debug.Log("Starting convo with " + dialogue.NPCData.characterName);
            animator.SetBool("IsOpen", true);

            NPCName.text = dialogue.NPCData.characterName;

            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
            }

            DisplayNextSentence();
       
    }

    //Changes the text to display the next item in array
    public void DisplayNextSentence()
    {
        //Checks how many sentences are left. If its the end, it ends dialogue instead.
        if (sentences.Count == 0)
        {
            
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        if(!animator.IsInTransition(0))
        {
            StartCoroutine(TypeSentence(sentence));
        }

    }

    //Types out the string in time with the coroutine
    IEnumerator TypeSentence(string sentence)
    {
        NPCSentence.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            NPCSentence.text += letter;
            yield return null;
        }
    }

    //Closes Dialogue Box
    void EndDialogue()
    {
        Debug.Log("End of conversation");
        animator.SetBool("IsOpen", false);
        dialogueActive = false;
    }
}

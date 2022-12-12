using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public AudioSource cut_completionDing;

    private int thornsCutOff;
    private int onionsCut;
    private int tomatosCut;
    private int nopalesCut;
    private int nopalesCooked;

    public NopalesSaladRecipe saladRecipe;
    public AudioSource imessageSound;


    // Start is called before the first frame update
    void Start()
    {


        dialogueManager = GetComponent<DialogueManager>(); //finds it ?



    }

    // Update is called once per frame
    void Update()
    {
        if (NopalesDethroned() == true)
        {
            Debug.Log("ready to move on");

        }
    }

    public void AddCount(String gm, int count)
    {
        if (gm == "thorn")
        {
            thornsCutOff += count;
        }

    }

    public bool NopalesDethroned()
    {
        if (thornsCutOff >= 195)
        {
            Debug.Log("All the thorns are off");
            return true;
        }

        return false;
    }

    public void NopalesFinal()
    {

    }



    //checks to see when a task has  been done,
    
    
    public void CutCompletedTask()
    {
        //plays a ding and then a couple seconds later calls 
        cut_completionDing.Play();

        //UNCOMMENT
        //StartCoroutine(PlayMessageSound());
    }

    IEnumerator PlayMessageSound()
    {
        yield return new WaitForSeconds(5);
        imessageSound.Play();
    }

}

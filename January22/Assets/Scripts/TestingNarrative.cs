using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;


public class TestingNarrative : MonoBehaviour
{
    public TextAsset inkJSONAsset;
    private Story story;
    
    private void Start()
    {
        
        Debug.Log("script started");
    }
    
     string getNextStoryBlock()
    {
        string text = "";

        if(story.canContinue)
        {
            text = story.Continue();
        }

        return text;
    }
    
    public void TestedClick()
    {
        story = new Story(inkJSONAsset.text);

        Debug.Log( getNextStoryBlock());

        foreach (Choice choice in story.currentChoices)
        {
            Debug.Log("The index is " + choice.index + " and its text is '" + choice.text + "'");           
        }

        story.ChooseChoiceIndex(0);

        Debug.Log(getNextStoryBlock());
    }
    
 
}

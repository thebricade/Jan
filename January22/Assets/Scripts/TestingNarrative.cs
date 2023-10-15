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
        /* story = new Story(inkJSONAsset.text);}

        Debug.Log( getNextStoryBlock());
        
        // Create a new GameObject
        GameObject newGameObject = new GameObject("TextChunk");
        // Set its transform to the Canvas (this)
        newGameObject.transform.SetParent(this.transform, false);
        
        // Add a new Text component to the new GameObject
        //Text newTextObject = newGameObject.AddComponent<Text>();
        // Set the fontSize larger
        newTextObject.fontSize = 24;
        // Set the text from new story block
        newTextObject.text = getNextStoryBlock();
        // Load Arial from the built-in resources
        newTextObject.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
        
        
        foreach (Choice choice in story.currentChoices)
        {
            Debug.Log("The index is " + choice.index + " and its text is '" + choice.text + "'");           
        }

        story.ChooseChoiceIndex(0);

        Debug.Log(getNextStoryBlock());
        */ 
    }
    
 
}

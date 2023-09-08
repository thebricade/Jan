using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus; 

public class PhoneManager : MonoBehaviour
{
    public  Flowchart _flowchart; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TappedNotification()
    {
        Debug.Log("I tapped a notification");
        _flowchart.SendFungusMessage("NotificationClicked");
        
    }
}

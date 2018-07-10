using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{
    [SerializeField] State startingState;
    [SerializeField] Text textbox;
   
    
    State state;

	// Use this for initialization
	void Start ()
    {
        state = startingState;
        textbox.text = state.GetStateStory();
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        ManageState();
	}

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
       // else if (Input.GetKeyDown(KeyCode.Alpha3))
       // {
        //    state = nextStates[2];
       // }
        textbox.text = state.GetStateStory();
    }

   
}

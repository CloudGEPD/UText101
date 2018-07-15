using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Adventure : MonoBehaviour
{
    [SerializeField] State startingState;
    [SerializeField] TextMeshProUGUI textMesh;
     State state;

	// Use this for initialization
	void Start ()
    {
        state = startingState;
        textMesh.text = state.GetStateStory();
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        ManageState();
    
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for(int index = 0; index < nextStates.Length; index++ )
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }
       if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
       textMesh.text = state.GetStateStory();
    }

    
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{
    [SerializeField] State startingState;
    [SerializeField] Text textbox;

    string[] oddDays = { "mon", "tues", "wed", "thur"};

    State state;

	// Use this for initialization
	void Start ()
    {
        state = startingState;
        textbox.text = state.GetStateStory();
        print(oddDays[1]);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Message : MonoBehaviour {

	Text messageText;

	void Awake()
	{
		messageText = GetComponent<Text>();
		messageText.enabled = false;
	}


	// Use this for initialization
	public void DisplayMessage()
	{
		messageText.enabled = true;
	}

	public void HideMessage()
	{
		messageText.enabled = false;
	}
}

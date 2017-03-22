using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotTrigger : MonoBehaviour {

	public Message messageText;

	Robot myParentRobot;

	bool inDaZone;

	void Awake()
	{
		myParentRobot = transform.parent.gameObject.GetComponent<Robot>();
		inDaZone = false;
	}

	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			messageText.DisplayMessage();
			inDaZone = true;
			
		}
	}

	void Update()
	{
		if(inDaZone)
		{
			if(Input.GetKeyDown(KeyCode.X))
			{
				myParentRobot.WasTriggered();
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			messageText.HideMessage();
			inDaZone = false;
		}
	}

	void OnDestroy()
	{
		messageText.HideMessage();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyFunnyInterfaces;

public class Robot : MonoBehaviour, IDammageable {

	public int HP = 25;
	public int damagePerInsult = 25;

	// Use this for initialization
	void Start () {
	}

	public void WasTriggered()
	{
		TakeDamage(damagePerInsult);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage(int dmgTaken)
	{
		HP -= dmgTaken;
		print("hi i am robot i just took " + dmgTaken + " due to insult");
		AssessDamage();
	}

	public void AssessDamage()
	{
		print("i am robot i have " + HP + " left");
		if(HP <= 0)
		{
			print("i am dead");
			Destroy(gameObject);
		}
	}



}

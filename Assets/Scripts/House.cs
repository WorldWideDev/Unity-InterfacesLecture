using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyFunnyInterfaces;
public class House : MonoBehaviour, IDammageable {

	public int HP = 25;
	MeshRenderer rendererHouse;

	void Awake()
	{
		rendererHouse = GetComponent<MeshRenderer>();
	}

	public void TakeDamage(int dmg)
	{
		HP -= dmg;
		print("hi i am house, now i have: " + HP + " health");
		Color newColor = rendererHouse.material.color;
		print(newColor.b);
		newColor.b -= .25f;
		newColor.g -= .25f;
		rendererHouse.material.color = newColor;
		AssessDamage();
	}

	public void AssessDamage()
	{
		if(HP <= 0)
		{
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.collider.tag == "Player")
		{
			int thisDamage = Random.Range(3, 10);
			TakeDamage(thisDamage);
			print("I am the house and i just took: " + thisDamage);
		}
	}
}
